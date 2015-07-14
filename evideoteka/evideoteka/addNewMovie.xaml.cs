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
    public partial class addNewMovie
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
            try
            {
                distributer dbId = (distributer)listBoxDistributor.SelectedItem;
                name = txtBoxNaziv.Text;
                year = txtBoxYear.Text;
                duration = txtBoxDuration.Text;
                language = txtBoxLanguage.Text;
                country = txtBoxCountry.Text;
                address = dbId.idDistributer.ToString();

                string query = "insert into film(naziv, godina, trajanje, jezik, zemlja, putanja, distributer) values ( " + "'" + name + "'" + "," + "'" + year + "'" + "," + "'" + duration + "'" + "," + "'" + language + "'" + "," + "'" + country + "'" + "," + "'" + path + "'" + "," + "'" + address + "'" + ")";
                string query2 = query.Replace(@"\", @"\\");
                db.insert(query2);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali distributera");

            }
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

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtBoxYear.Text.ToString(), out parsedValue))
            {
                btnAddMovie.IsEnabled = true;
                txtBoxYear.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddMovie.IsEnabled = false;
                txtBoxYear.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxDuration_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (int.TryParse(txtBoxDuration.Text.ToString(), out parsedValue))
            {
                btnAddMovie.IsEnabled = true;
                txtBoxDuration.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddMovie.IsEnabled = false;
                txtBoxDuration.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxLanguage_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxLanguage.Text.ToString(), out parsedValue))
            {
                btnAddMovie.IsEnabled = true;
                txtBoxLanguage.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddMovie.IsEnabled = false;
                txtBoxLanguage.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void txtBoxCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txtBoxCountry.Text.ToString(), out parsedValue))
            {
                btnAddMovie.IsEnabled = true;
                txtBoxCountry.BorderBrush = new SolidColorBrush(Colors.Black);
            }
            else
            {
                btnAddMovie.IsEnabled = false;
                txtBoxCountry.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
