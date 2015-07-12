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
            string query = "insert into korisnik(ime, prezime, telefon, email, status, tip, korisnickoIme, sifra, adresa) values ( " + "'" + name + "'" + "," + "'" + surname + "'" + "," + "'" + phone + "'" + "," + "'" + email +"'" +"," + "'" + status + "'" + "," + "'" + type +"'" + "," + "'" + userName +"'" + "," + "'" + password + "'" + "," + "'" + address + "'" + ")";
            db.insert(query);
            

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
