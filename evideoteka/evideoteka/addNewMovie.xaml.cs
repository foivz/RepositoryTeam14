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
    /// Interaction logic for addNewMovie.xaml
    /// </summary>
    public partial class addNewMovie : Window
    {
        baza db;
        List<distributer> distributor;
        String name, year, duration, language, country, address, path;
        public addNewMovie()
        {
            InitializeComponent();
            db = new baza();
            distributor = new List<distributer>();
            distributor = db.SelectMovieDistributor();
            foreach (distributer d in distributor)
            {
                listBoxDistributor.Items.Add(d);
                
            }
        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            distributer dbId = (distributer)listBoxDistributor.SelectedItem;
            name = txtBoxNaziv.Text;
            year = txtBoxYear.Text;
            duration = txtBoxDuration.Text;
            language = txtBoxLanguage.Text;
            country = txtBoxCountry.Text;
            address = dbId.idDistributer.ToString();
            
            string query = "insert into film(naziv, godina, trajanje, jezik, zemlja, putanja, distributer) values ( " + "'" + name + "'" + "," + "'" + year + "'" + "," + "'" + duration + "'" + "," + "'" + language + "'" + "," + "'" + country + "'" + "," + "'" + path + "'" + "," + "'" + address + "'"  + ")";
            string query2 = query.Replace(@"\", @"\\");
            db.insert(query2);
            
        }

        private void btnAddPath_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = fd.ShowDialog();
            if (result == true)
            {
                path = fd.FileName;
                MessageBox.Show(path);
            }
        }
    }
}
