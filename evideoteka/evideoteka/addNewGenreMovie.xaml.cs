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
    /// Interaction logic for addNewGenreMovie.xaml
    /// </summary>
    public partial class addNewGenreMovie : Window
    {
        baza db;
        List<film> choseMovie;
        List<zanr> choseGenre;
        public addNewGenreMovie()
        {
            InitializeComponent();
            db = new baza();
            choseMovie = new List<film>();
            choseGenre = new List<zanr>();
            choseMovie = db.SelectMovie();
            choseGenre = db.SelectGenre();
            foreach (film f in choseMovie)
            {
                listBoxAddMovie.Items.Add(f);
            }
            foreach (zanr z in choseGenre)
            {
                listBoxAddGenre.Items.Add(z);
            }
        }

        private void btnAddMovieGenre_Click(object sender, RoutedEventArgs e)
        {
            film selectedMovie = (film)listBoxAddMovie.SelectedItem;
            zanr selectedGenre = (zanr)listBoxAddGenre.SelectedItem;
            string query = "insert into filmzanr  values (" + "'" + selectedMovie.idFilm + "'" + "," + "'" + selectedGenre.idZanr + "'" + ")";
            db.insert(query);
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
