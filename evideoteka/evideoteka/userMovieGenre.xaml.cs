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
    /// Interaction logic for userMovieGenre.xaml
    /// </summary>
    public partial class userMovieGenre
    {
        List<film> selectMovie;
        List<zanr> selectGenre;
        List<filmzanr> selectMovieGenre;
        baza db;
        public userMovieGenre()
        {
            InitializeComponent();
            db = new baza();
            selectGenre = new List<zanr>();
            selectMovie = new List<film>();
            selectMovieGenre = new List<filmzanr>();
            selectGenre = db.SelectGenre();
            selectMovie = db.SelectMovie();
            selectMovieGenre = db.SelectMovieGenre();
            foreach (zanr z in selectGenre){
                listBoxGenre.Items.Add(z);
            }
        }

        private void listBoxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBoxMovie.Items.Clear();
            zanr selectedGenre = (zanr)listBoxGenre.SelectedItem;
          
            foreach (filmzanr fz in selectMovieGenre)
            {
                
                if (fz.idZanr == selectedGenre.idZanr)
                    
                {
                    foreach (film fi in selectMovie)
                    {
                        
                        if (fz.idFilm == fi.idFilm)
                        {
                            
                            listBoxMovie.Items.Add(fi);
                        }
                    }
                }
            }
        }

        private void listBoxMovie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
           
        }

        private void listBoxMovie_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            film selectedMovie = (film)listBoxMovie.SelectedItem;
            String path = selectedMovie.putanja;
            var playMovie = new user(path);
            playMovie.Show();
        }


    }
}
