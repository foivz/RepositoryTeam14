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
    /// Interaction logic for addNewDirector.xaml
    /// </summary>
    public partial class addNewDirector
    {
        baza db;
        String name, surname, year;
        public addNewDirector()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddDirector_Click(object sender, RoutedEventArgs e)
        {
            name = txtBoxName.Text;
            surname = txtBoxSurname.Text;
            year = txtBoxYear.Text;
            string query = "insert into redatelj(ime, prezime, datumRodjenja) values ( " + "'" + name + "'" + "," + "'" + surname + "'" + "," + "'" + year + "'" + ")";
            db.insert(query);
        }
    }
}
