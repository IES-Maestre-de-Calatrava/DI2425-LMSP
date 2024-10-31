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

namespace WpfAppStack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Small(object sender, RoutedEventArgs e)
        {
            this.miSlide.Value = this.miSlide.Minimum;
        }
        private void Button_Click_Normal(object sender, RoutedEventArgs e)
        {
            this.miSlide.Value = (this.miSlide.Minimum + this.miSlide.Maximum)/2;
        }
        private void Button_Click_Big(object sender, RoutedEventArgs e)
        {
            this.miSlide.Value = this.miSlide.Maximum;
        }
    }
}