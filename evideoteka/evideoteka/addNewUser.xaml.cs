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
    /// Interaction logic for addNewUser.xaml
    /// </summary>
    public partial class addNewUser
    {
        baza db;
        String name, surname, phone, email, status, type, userName, password, address;
        public addNewUser()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {


            name = txtBoxName.Text;
            surname = txtBoxSurname.Text;
            phone = txtBoxPhone.Text;
            email = txtBoxEmail.Text;
            status = txtBoxStatus.Text;
            type = txtBoxType1.Text;
            userName = txtBoxUserName.Text;
            password = txtBoxPassword.Text;
            address = txtBoxAddress.Text;
            string query = "insert into korisnik(ime, prezime, telefon, email, status, tip, korisnickoIme, sifra, adresa) values ( " + "'" + name + "'" + "," + "'" + surname + "'" + "," + "'" + phone + "'" + "," + "'" + email + "'" + "," + "'" + status + "'" + "," + "'" + type + "'" + "," + "'" + userName + "'" + "," + "'" + password + "'" + "," + "'" + address + "'" + ")";
            db.insert(query);



        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxName.Text.ToString(), out parsedValue))
            {
                btnAddUser.IsEnabled = true;
                txtBoxName.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddUser.IsEnabled = false;
                txtBoxName.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxSurname.Text.ToString(), out parsedValue))
            {
                btnAddUser.IsEnabled = true;
                txtBoxSurname.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddUser.IsEnabled = false;
                txtBoxSurname.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtBoxStatus.Text.ToString(), out parsedValue))
            {
                btnAddUser.IsEnabled = true;
                txtBoxStatus.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddUser.IsEnabled = false;
                txtBoxStatus.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxType1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtBoxType1.Text.ToString(), out parsedValue))
            {
                btnAddUser.IsEnabled = true;
                txtBoxType1.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddUser.IsEnabled = false;
                txtBoxType1.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
