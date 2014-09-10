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

namespace evideoteka
{
    /// <summary>
    /// Interaction logic for addNewGenre.xaml
    /// </summary>
    public partial class addNewGenre : Window
    {
        string name, description;
        baza db;
        public addNewGenre()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddGenre_Click(object sender, RoutedEventArgs e)
        {
            name = txtBoxName.Text;
            description = txtBoxDescription.Text;
            string query = "insert into zanr(naziv, opis) values ( " + "'" + name + "'" + "," + "'" + description + "'" +  ")";
            db.insert(query);
        }
    }
}
