using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfTPV.View
{
    /// <summary>
    /// Lógica de interacción para TicketWindow.xaml
    /// </summary>
    public partial class TicketWindow : Window
    {
        public TicketWindow(List<Producto_Ticket> lista)
        {
            InitializeComponent();
            mostrarTicket(lista);
        }

        private void mostrarTicket(List<Producto_Ticket> lista)
        {
            TextBlock tbTicket = new TextBlock();
            double total = lista.Sum(p => p.Total);
            string outStr = "";
            foreach (Producto_Ticket pt in lista)
            {
                outStr += "# Producto: " + pt.Producto.Nombre + ", Cantidad: " + pt.Unidades + ", Precio: " + pt.Producto.Precio + " €, Total: " + pt.Total + " €\n";
            }
            outStr += "\n" + "*************************************************************";
            outStr += "************************\n************************-> TOTAL A PAGAR: " + total.ToString("F2") + " € <-************";
            tbTicket.Text = outStr;
            ticketGrid.Children.Add(tbTicket);
        }
    }
}

