using DataGridPerson.Domain;
using DataGridPerson.Persistance;
using Google.Protobuf;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace DataGridPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> listPerson;
        private PersonManage pm;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                pm = new PersonManage();
                listPerson = new List<Person>();
                dataPerson.ItemsSource = listPerson;
                pm.ReadPerson();
            }catch (InvalidJsonException ex)
            {
                Console.WriteLine("Error when JSON reading: " + ex.Message);
            }
        }

        private void addPerson_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(ageText.Text, out int ageAdd) && ageAdd > 0)
            {   if(nameText.Text.Equals(string.Empty) || surnameText.Text.Equals(string.Empty))
                {
                    // Mostrar un mensaje de error al usuario
                    MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                }
                else
                {
                    listPerson.Add(new Person(nameText.Text, surnameText.Text, ageAdd));
                    dataPerson.Items.Refresh();
                    nameText.Text = string.Empty;
                    surnameText.Text = string.Empty;
                    ageText.Text = string.Empty;
                }
            }
            else
            {
                // Mostrar un mensaje de error al usuario
                MessageBox.Show("Por favor, ingrese una edad válida.", "Error");
            }
        }

        private void modify_Click(object sender, RoutedEventArgs e)
        {
            if (dataPerson.SelectedItem != null)
            {
                Person person = (Person)dataPerson.SelectedItem;
                if (Int32.TryParse(ageText.Text, out int ageModify) && ageModify > 0)
                {
                    if (nameText.Text.Equals(string.Empty) || surnameText.Text.Equals(string.Empty))
                    {
                        // Mostrar un mensaje de error al usuario
                        MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                    }
                    else
                    {
                        person.Name = nameText.Text;
                        person.SurName = surnameText.Text;
                        person.Age = ageModify;
                        dataPerson.Items.Refresh();
                        nameText.Text = string.Empty;
                        surnameText.Text = string.Empty;
                        ageText.Text = string.Empty;
                    }
                }
                else
                {
                    // Mostrar un mensaje de error al usuario
                    MessageBox.Show("Por favor, ingrese una edad válida.", "Error");
                }
            }
            else
            {
                // Mostrar un mensaje de error al usuario
                MessageBox.Show("Por favor, seleccione una persona.", "Error");
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (dataPerson.SelectedItem != null)
            {
                Person person = (Person)dataPerson.SelectedItem;
                listPerson.Remove(person);
                dataPerson.Items.Refresh();
            }
            else
            {
                // Mostrar un mensaje de error al usuario
                MessageBox.Show("Por favor, seleccione una persona.", "Error");
            }
        }

        private void dataPerson_Selection(object sender, SelectionChangedEventArgs e)
        {
            if (dataPerson.SelectedItem != null)
            {
                Person person = (Person)dataPerson.SelectedItem;
                nameText.Text = person.Name;
                surnameText.Text = person.SurName;
                ageText.Text = Convert.ToString(person.Age);
            }
            else
            {
                nameText.Text = string.Empty;
                surnameText.Text = string.Empty;
                ageText.Text = string.Empty;
            }
        }

        private void btnInserta_Click(object sender, RoutedEventArgs e)
        {
            List<Person> lista = new List<Person>();
            try
            {
                pm.ReadPerson();
                lista = pm.listPerson;
                foreach (Person p in lista)
                {
                    listPerson.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos de la base de datos: " + ex.Message, "Error");

            }

        }
    }
}