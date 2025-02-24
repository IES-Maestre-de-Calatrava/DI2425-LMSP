using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pruebasAntesdeExamen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            HaceAlgo();
        }
        /// <summary>
        /// Nohaces the nada.
        /// </summary>
        public static void NohaceNada()
        {
            Console.WriteLine("No hace nada");
        }
        public void HaceAlgo()
        {
            DataTable dt = new DataTable("DataTable1");
            dt.Columns.Add("Juan");
            dt.Columns.Add("Garcia");
            DataRow row = dt.NewRow();
            row["Juan"] = "Juanete";
            row["Garcia"] = "Garcilaso";
            dt.Rows.Add(row);

            CrystalReport1 report = new CrystalReport1();
            report.Database.Tables["DataTable1"].SetDataSource(dt);
            viewer.ViewerCore.ReportSource = report;


        }
    }
    
}
