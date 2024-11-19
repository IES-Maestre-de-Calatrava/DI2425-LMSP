using Gestpro.Dominio;
using Gestpro.persistence.manages;
using System;
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
    public partial class MainWindow : Window
    {
        private List<Proyectos> listProject;
        public MainWindow()
        {
            InitializeComponent();
            listProject = new List<Proyectos>();
            dataProject.ItemsSource = listProject;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
                if (tbNombre.Text.Equals(string.Empty) || tbFechaInicio.Text.Equals(string.Empty) || tbFechaFin.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                }
                else
                {
                    listProject.Add(new Proyectos(tbCodProy.Text,tbNombre.Text,tbFechaInicio.Text,tbFechaFin.Text));
                    dataProject.Items.Refresh();
                    tbCodProy.Text = string.Empty;
                    tbNombre.Text = string.Empty;
                    tbFechaInicio.Text = string.Empty;
                    tbFechaFin.Text = string.Empty;
                }
            
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            if (dataProject.SelectedItem != null)
            {
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                
                    if (tbNombre.Text.Equals(string.Empty) || tbFechaInicio.Text.Equals(string.Empty)|| tbFechaFin.Text.Equals(string.Empty))
                    {
                        // Mostrar un mensaje de error al usuario
                        MessageBox.Show("Ningun campo puede estar vacio.", "Error");
                    }
                    else
                    {
                        proyecto.CodProy = tbCodProy.Text;
                        proyecto.Nombre = tbNombre.Text;
                        proyecto.FechaInicio = tbFechaInicio.Text;
                        proyecto.FechaFin = tbFechaFin.Text;
                        dataProject.Items.Refresh();
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

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dataProject.SelectedItem != null)
            {
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                listProject.Remove(proyecto);
                dataProject.Items.Refresh();
            }
            else
            {
                // Mostrar un mensaje de error al usuario
                MessageBox.Show("Por favor, seleccione un proyecto", "Error");
            }
        }

        private void dataProject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataProject.SelectedItem != null)
            {
                Proyectos proyecto = (Proyectos)dataProject.SelectedItem;
                tbCodProy.Text = Convert.ToString(proyecto.CodProy);
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

        private void CargarDatos_Click(object sender, RoutedEventArgs e)
        {
            ProjectManage pm = new ProjectManage();
            List<Proyectos> list = new List<Proyectos>();
            for (int i = 0; i < 20; i++)
            {
                String Name = "Allegro";
                String Cod = "MTR" + (i + 1) + Name + DateTime.Now.Year.ToString();

                Proyectos p = new Proyectos(Cod, Name, DateTime.Now.ToString(),DateTime.Now.ToString());
                list.Add(p);
                pm.insertProject(p);
            }

        }
    }
}