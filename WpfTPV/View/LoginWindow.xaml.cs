using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfTPV.Domain;
using WpfTPV.Persistence.Manage;

namespace WpfTPV.View
{
    /// <summary>
    /// Lógica de interacción para LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String username = tbUsername.Text.ToString();
            String password = tbPassword.Password.ToString();

            String passwordSHA = cifraSHA(password);

            Usuario usuario = UsuariosManage.encontrarUsuario(username);

            if (usuario != null)
            {
                if (passwordSHA.Equals(usuario.Pass))
                { 
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Inicio incorrecto", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos estan imcompletos o el usuario es incorrecto,", "Incompleto", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
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
    }
}
