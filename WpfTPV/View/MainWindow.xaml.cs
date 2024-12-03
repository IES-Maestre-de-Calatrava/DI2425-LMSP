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
using WpfTPV.Domain;

namespace WpfTPV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Producto productoSeleccionado;
        private List<Producto> listTicket;
        public MainWindow()
        {
            InitializeComponent();
            listTicket = new List<Producto>();
        }
        #region Product buttons
        private void btnToast_Click(object sender, RoutedEventArgs e)
        {
            productoSeleccionado = new Producto(Producto.TOAST, "Tostada", 1.5, 1);
        }
        private void btnCroissant_Click(object sender, RoutedEventArgs e)
        {
            productoSeleccionado = new Producto(Producto.TOAST, "Croissant", 1.5, 1);
        }
        private void btnChurro_Click(object sender, RoutedEventArgs e)
        {
            productoSeleccionado = new Producto(Producto.TOAST, "Churro", 1.5, 1);
        }

        private void btnPorra_Click(object sender, RoutedEventArgs e)
        {
            productoSeleccionado = new Producto(Producto.TOAST, "Porra", 1.5, 1);
        }

        #endregion
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            listTicket.Add(productoSeleccionado);
        }

        
    }
}