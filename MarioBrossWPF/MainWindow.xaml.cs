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

namespace MarioBrossWPF
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(tbLives.Text, out int lives) && Int32.TryParse(tbPotions.Text, out int potions))
            {
                Mario player = new Mario(lives, potions);

            }
            else
            {
                MessageBox.Show("Deben ser valores enteros.");
            }
            Dashboard dashboard = new Dashboard(dashboardGrid.RowDefinitions.Count(), dashboardGrid.ColumnDefinitions.Count());
            dashboard.InitDash();
            for (int i = 0; i < dashboardGrid.RowDefinitions.Count(); i++)
            {
                for (int j = 0; j < dashboardGrid.ColumnDefinitions.Count(); j++)
                {
                    Label lbl_dash = new Label();
                    lbl_dash.Content = dashboard.dash[i,j];
                    dashboardGrid.Children.Add(lbl_dash);

                }
            }
         

        }
    }
}