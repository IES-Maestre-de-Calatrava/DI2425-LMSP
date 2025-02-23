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
using Org.BouncyCastle.Asn1.Cmp;
using ReadingClub.Domain;
using ReadingClub.View;
using SAPBusinessObjects.WPF.Viewer;

namespace ReadingClub
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> listBooks;
        List<Member> members;
        public MainWindow()
        {
            InitializeComponent();
            listBooks = new List<Book>();
            dataBooks.ItemsSource = listBooks;
            members = new List<Member>();
            dataMembers.ItemsSource = members;
        }
        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            String title = tbTitle.Text;
            String author = tbAuthor.Text;
            String genre = cbGenre.Text;
            int year = Convert.ToInt32(tbPYear.Text);
            Book b = new Book(genre, title, author, year);
            listBooks.Add(b);
            dataBooks.Items.Refresh();
            tbTitle.Text = String.Empty;
            tbAuthor.Text = String.Empty;
            cbGenre.Text = String.Empty;
            tbPYear.Text = String.Empty;
        }

        private void dataBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBooksReport_Click(object sender, RoutedEventArgs e)
        {
            
            DataSet dsBook = new DataSet("DataSetBooks");
            DataTable dtBooks = new DataTable("Books");

            dtBooks.Columns.Add("Genre");
            dtBooks.Columns.Add("Title");
            dtBooks.Columns.Add("Author");
            dtBooks.Columns.Add("Year");


            foreach (Book b in listBooks)
            {
                DataRow dr = dtBooks.NewRow();
                dr["Genre"] = b.Genre;
                dr["Title"] = b.Title;
                dr["Author"] = b.Author;
                dr["Year"] = b.PYear;
                dtBooks.Rows.Add(dr);
                

            }

            CrystalReportBooks crb = new CrystalReportBooks();
            crb.SetDataSource(dtBooks);
           
            viewer.ViewerCore.ReportSource = crb;



        }

        private void btnLendingsReport_Click(object sender, RoutedEventArgs e)
        {
            DataSet dsLending = new DataSet();
            DataTable dtLending = new DataTable("DataSetLendings");

            dtLending.Columns.Add("Name of member");
            dtLending.Columns.Add("Title of book");
            dtLending.Columns.Add("Loan date");
            dtLending.Columns.Add("Return date");

            foreach (Book b in listBooks)
            {
                DataRow dr = dtLending.NewRow();
                dr["Name of member"] = b.Genre;
                dr["Title of book"] = b.Title;
                dr["Loan date"] = b.Author;
                dr["Return date"] = b.PYear;
                dtLending.Rows.Add(dr);

            }

            CrystalReportLending crb = new CrystalReportLending();
            crb.SetDataSource(dtLending);

            viewerLending.ViewerCore.ReportSource = crb;
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            String name = tbNameE.Text;
            String birth = dpBirth.Text;
            String email = tbMail.Text;
            String phone = tbPhone.Text;
            Member m = new Member(name,birth, email, phone);
            members.Add(m);
            dataMembers.Items.Refresh();
            tbNameE.Text = String.Empty;
            dpBirth.Text = String.Empty;
            tbMail.Text = String.Empty;
            tbPhone.Text = String.Empty;

        }
    }
}
