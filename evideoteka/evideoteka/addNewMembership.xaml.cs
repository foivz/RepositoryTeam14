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
    /// Interaction logic for addNewMembership.xaml
    /// </summary>
    public partial class addNewMembership
    {
        baza db;
        DateTime dt, dtUntil;
        List<model> model;
        List<korisnik> user;
        public addNewMembership()
        {
            InitializeComponent();
            db = new baza();
            dt = new DateTime();
            dtUntil = new DateTime();
            model = new List<model>();
            user = new List<korisnik>();
            model = db.SelectModel();
            user = db.Select();
            foreach (model m in model)
            {
                listBoxModel.Items.Add(m);
            }

            foreach (korisnik k in user)
            {
                listBoxUser.Items.Add(k);
            }
        }

        private void btnAddMembership_Click(object sender, RoutedEventArgs e)
        {
            dt = new DateTime();
            dtUntil = new DateTime();
            dt = DateTime.Now;
            model currentModel = (model)listBoxModel.SelectedItem;
            korisnik currentUser = (korisnik)listBoxUser.SelectedItem;
            dtUntil = dt.AddDays(currentModel.trajanje);
            string date1 = dt.ToString("yyyy-MM-dd HH:mm:ss");
            string date2 = dtUntil.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "insert into clanarina (model, korisnik, datumAktivacija, datumDeaktivacije) values (" + "'" + currentModel.idKorisnik + "'" + "," + "'" + currentUser.idKorisnik + "'" + "," + "'" + date1 + "'" + "," + "'" + date2 + "'" +  ")";
            db.insert(query);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void listBoxModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
