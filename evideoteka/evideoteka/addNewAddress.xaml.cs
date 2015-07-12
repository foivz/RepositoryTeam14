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
    /// Interaction logic for addNewAddress.xaml
    /// </summary>
    public partial class addNewAddress
    {
        string postNumber, place, street;
        baza db;
        public addNewAddress()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnAddAddress_Click(object sender, RoutedEventArgs e)
        {
            postNumber = txtBoxPostNumber.Text;
            place = txtBoxMjesto.Text;
            street = txtBoxUlica.Text;
            string query = "insert into adresa(postanskiBroj, mjesto, ulica) values ( " + "'" + postNumber + "' " + "," + "'" + place + "'" + "," + "'" + street + "'" + ")";
            db.insert(query);
           
        }

        private void btnCloseAddress_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
