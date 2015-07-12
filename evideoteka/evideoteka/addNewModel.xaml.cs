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
    /// Interaction logic for addNewModel.xaml
    /// </summary>
    public partial class addNewModel
    {
        baza db;
        String name, description, price, length;
        public addNewModel()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddModel_Click(object sender, RoutedEventArgs e)
        {
            name = txtBoxName.Text;
            description = txtBoxDescription.Text;
            price = txtBoxPrice.Text;
            length = txtBoxLength.Text;
            string query = "insert into model(naziv, opis, cijena, trajanje) values ( " + "'" + name + "'" + "," + "'" + description + "'" + "," + "'" + price + "'" + "," + "'" + length + "'" + ")";
            db.insert(query);
        }
    }
}
