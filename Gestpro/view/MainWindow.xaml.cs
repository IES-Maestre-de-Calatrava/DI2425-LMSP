using Gestpro.Dominio;
using Gestpro.persistence.manages;
using System;
using System.Security.Cryptography;
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

namespace Gestpro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The list project
        /// </summary>
        private List<Proyectos> listProject;
        /// <summary>
        /// The list user
        /// </summary>
        private List<User> listUser;
        /// <summary>
        /// The list employees
        /// </summary>
        private List<Employ> listEmployees;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            listProject = new List<Proyectos>();
            listUser = new List<User>();
            listEmployees = new List<Employ>();
            dataProject.ItemsSource = listProject;
            dataUser.ItemsSource = listUser;
            dataEmploy.ItemsSource = listEmployees;
        }
        #region Eventos Proyectos
        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
                if (tbNombre.Text.Equals(string.Empty) || tbFechaInicio.Text.Equals(string.Empty) || tbFechaFin.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                }
                else
                {
                    Proyectos proyectos = new Proyectos(tbCodProy.Text, tbNombre.Text, tbFechaInicio.Text, tbFechaFin.Text);
                    listProject.Add(proyectos);
                    dataProject.Items.Refresh();
                    ProjectManage pm = new ProjectManage();
                    pm.insertProject(proyectos);
                    tbCodProy.Text = string.Empty;
                    tbNombre.Text = string.Empty;
                    tbFechaInicio.Text = string.Empty;
                    tbFechaFin.Text = string.Empty;
                }
            
        }

        /// <summary>
        /// Handles the Click event of the btnModify control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            ProjectManage pm = new ProjectManage();
            if (dataProject.SelectedItem != null)
            {
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                
                    if (tbNombre.Text.Equals(string.Empty) || tbFechaInicio.Text.Equals(string.Empty)|| tbFechaFin.Text.Equals(string.Empty))
                    {
                        // Mostrar un mensaje de error al user
                        MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                    }
                    else
                    {
                        string auxCod = proyecto.CodProy;
                        proyecto.CodProy = tbCodProy.Text;
                        proyecto.Nombre = tbNombre.Text;
                        proyecto.FechaInicio = tbFechaInicio.Text;
                        proyecto.FechaFin = tbFechaFin.Text;
             
                        dataProject.Items.Refresh();
                        pm.modifyProject(proyecto, auxCod);

                        tbCodProy.Text = string.Empty;
                        tbNombre.Text = string.Empty;
                        tbFechaInicio.Text = string.Empty;
                        tbFechaFin.Text = string.Empty;
                    }
            
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proyecto.", "Error");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ProjectManage pm = new ProjectManage();
            if (dataProject.SelectedItem != null)
            {   
                
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                pm.deleteProject(proyecto);
                listProject.Remove(proyecto);
                dataProject.Items.Refresh();
            }
            else
            {
                // Mostrar un mensaje de error al user
                MessageBox.Show("Por favor, seleccione un proyecto", "Error");
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dataProject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void dataProject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataProject.SelectedItem != null)
            {
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                tbCodProy.Text = proyecto.CodProy;
                tbNombre.Text = proyecto.Nombre;
                tbFechaInicio.Text = proyecto.FechaInicio;
                tbFechaFin.Text = proyecto.FechaFin;
            }
            else
            {
                tbCodProy.Text = string.Empty;
                tbNombre.Text = string.Empty ;
                tbFechaInicio.Text = string.Empty;
                tbFechaFin.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the Click event of the CargarDatos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void CargarDatos_Click(object sender, RoutedEventArgs e)
        {
            ProjectManage pm = new ProjectManage();
            for (int i = 0; i < 20; i++)
            {
                String Name = "Allegro";
                String Cod = "MTR" + (i + 1) + Name + DateTime.Now.Year.ToString();

                Proyectos p = new Proyectos(Cod, Name, DateTime.Now.ToString(),DateTime.Now.ToString());
                listProject.Add(p);
                dataProject.Items.Refresh();
                pm.insertProject(p);
            }

        }
        #endregion
        #region Soluciones y eventos para Usuario
        /// <summary>
        /// Handles the Click event of the btnDarAlta control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDarAlta_Click(object sender, RoutedEventArgs e)
        {
            String username = tbUsername.Text.ToString();
            String password = tbPass.Password.ToString();
            if (tbUsername.Text.Equals(string.Empty) || tbPass.Password.Equals(string.Empty))
            {
                MessageBox.Show("Ningun campo puede estar vacio.", "Error");
            }
            else
            {
                String passwordSHA = cifraSHA(password);

                User user = new User(username, passwordSHA);
                listUser.Add(user);
                dataUser.Items.Refresh();
                UserManage um = new UserManage();
                um.insertUser(user);
                tbUsername.Text = string.Empty;
                tbPass.Password = string.Empty;
            }
            

           
        }
        /// <summary>
        /// Cifras the sha.
        /// </summary>
        /// <param name="cadena">The cadena.</param>
        /// <returns></returns>
        private static String cifraSHA(String cadena)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(cadena);

                // Sacar hash
                byte[] hash_bytes = sha512.ComputeHash(bytes);

                //Pasar hexadecimal
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash_bytes)
                {
                    sb.Append(b.ToString("x2"));//Para hacerlo Hexadecimal
                }

                return sb.ToString();

            }
        }
        /// <summary>
        /// Handles the SelectionChanged event of the dataUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void dataUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataUser.SelectedItem != null)
            {
                User u = (User)dataUser.SelectedItem;
                tbUsername.Text = u.Username;
               
            }
            
        }

        /// <summary>
        /// Handles the Click event of the btnDeleteUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (dataUser.SelectedItem != null)
            {
                UserManage um = new UserManage();
                User u = (User)dataUser.SelectedItem;
                um.deleteUser(u);
                listUser.Remove(u);
                dataUser.Items.Refresh();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario", "Error");
            }
        }

        /// <summary>
        /// Handles the Click event of the btnUpdatePass control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnUpdatePass_Click(object sender, RoutedEventArgs e)
        {
            if (dataUser.SelectedItem != null)
            {
                String newPass = cifraSHA(tbPass.Password.ToString());
                UserManage um = new UserManage();
                User u = (User)dataUser.SelectedItem;
                listUser.Remove(u);
                u.Password = newPass;
                um.updatePass(u);
                listUser.Add(u);
                dataUser.Items.Refresh();

            }
           
        }
        #endregion

        #region Soluciones y eventos para Empleado
        /// <summary>
        /// Handles the Click event of the btnAddEmploy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnAddEmploy_Click(object sender, RoutedEventArgs e)
        {
            String name = tbNameEm.Text.ToString();
            String surname = tbSurnameEm.Text.ToString();
            int rol = cbRol.SelectedIndex + 1;
            double csr = Double.Parse(tbCSR.Text.ToString()); 
            if (tbNameEm.Text.Equals(string.Empty) || tbSurnameEm.Text.Equals(string.Empty))
            {
                MessageBox.Show("Ningun campo puede estar vacio.", "Error");
            }
            else
            {
                Employ empleado = new Employ(name,surname,rol,csr);
                listEmployees.Add(empleado);
                dataEmploy.Items.Refresh();
                EmployManage em = new EmployManage();
                em.insertEmploy(empleado);
                tbNameEm.Text = string.Empty;
                tbSurnameEm.Text = string.Empty;
                cbRol.SelectedIndex = -1;
                tbCSR.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnModifyEmploy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnModifyEmploy_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnDeleteEmloy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnDeleteEmloy_Click(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Handles the SelectionChanged event of the dataEmploy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void dataEmploy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        #endregion

        private void btnShowReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}