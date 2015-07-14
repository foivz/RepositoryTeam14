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
    /// Interaction logic for addNewActor.xaml
    /// </summary>
    public partial class addNewActor
    {
        string actorName, actorSurname, actorYear;
        baza db;
        public addNewActor()
        {
            InitializeComponent();
            db = new baza();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //actor = new glumac();
            actorName = txtBoxActorName.Text;
            actorSurname = txtBoxActorSurname.Text;
            actorYear = txtBoxActorYear.Text;
            string query = "insert into glumac(ime, prezime, datumRodjenja) values ( " + "'" + actorName + "'" + "," + "'" + actorSurname + "'" + "," + "'" + actorYear + "'" + " )";
            db.insert(query);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxActorYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            DateTime parsedValue;
            if (!DateTime.TryParse(txtBoxActorYear.Text.ToString(), out parsedValue))
            {
                txtBoxActorYear.BorderBrush = new SolidColorBrush(Colors.Red);
                btnAdd.IsEnabled = false;
            }
            else
            {

                txtBoxActorYear.BorderBrush = new SolidColorBrush(Colors.Black);
                btnAdd.IsEnabled = true;
            }
        }

        private void txtBoxActorName_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxActorName.Text.ToString(), out parsedValue))
            {
                btnAdd.IsEnabled = true;
                txtBoxActorName.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAdd.IsEnabled = false;
                txtBoxActorName.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxActorSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxActorSurname.Text.ToString(), out parsedValue))
            {
                btnAdd.IsEnabled = true;
                txtBoxActorSurname.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAdd.IsEnabled = false;
                txtBoxActorSurname.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }








    }
}
