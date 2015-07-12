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
    /// Interaction logic for userMovieSearch.xaml
    /// </summary>
    public partial class userMovieSearch
    {
        baza db;
        List<film> searchByName;
        List<glumac> searchByActor;
        List<filmglumac> searchByActorMovie;
        public userMovieSearch()
        {

            InitializeComponent();
            db = new baza();
            searchByActor = new List<glumac>();
            searchByName = new List<film>();
            searchByActorMovie = new List<filmglumac>();
            searchByActor = db.SelectActor();
            searchByActorMovie = db.SelectMovieActor();
            searchByName = db.SelectMovie();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSearchName_Click(object sender, RoutedEventArgs e)
        {
            listBoxSearch.Items.Clear();
            String userNameSearch = txtBoxSearchName.Text;
            foreach (film f in searchByName)
            {
                if (f.naziv.Contains(userNameSearch))
                    listBoxSearch.Items.Add(f);
            }
        }

        private void btnSearchActor_Click(object sender, RoutedEventArgs e)
        {
            listBoxSearch.Items.Clear();
            String userActorSearch = txtBoxSearchActor.Text;
            foreach (glumac g in searchByActor)
            {
                if (g.ime.Contains(userActorSearch) || g.prezime.Contains(userActorSearch)) 
                {
                    foreach (filmglumac fm in searchByActorMovie)
                    {
                        if (fm.idGlumac == g.idGlumac)
                        {
                            foreach (film f in searchByName)
                            {
                                if (f.idFilm == fm.idFilm)
                                    listBoxSearch.Items.Add(f);
                            }
                        }
                    }
 
                
                }
            }
        }

        private void listBoxSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            film selectedMovie = (film)listBoxSearch.SelectedItem;
            String path = selectedMovie.putanja;
            var playMovie = new user(path);
            playMovie.Show();
        }
    }
}
