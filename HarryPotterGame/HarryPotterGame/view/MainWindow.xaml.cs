using HarryPotterGame.domain;
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

namespace HarryPotterGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character harry;
        Character hermione;
        Character ron;
        public MainWindow()
        {
            InitializeComponent();

            harry = new Character("Harry Potter",100);
            hermione = new Character("Hermione Granger",50);
            ron = new Character("Ronald Wesley");

            cboPlayer.Items.Add(harry.name);
            cboPlayer.Items.Add(hermione.name);
            cboPlayer.Items.Add(ron.name);

        


        }
    
        private void cboPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cboPlayer.SelectedIndex)
            {
                case 0:break;
            }
           
        
        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {
            btnNew.IsEnabled = false;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            btnDelete.IsEnabled = false;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            btnSave.IsEnabled = false;
        }
    }
}