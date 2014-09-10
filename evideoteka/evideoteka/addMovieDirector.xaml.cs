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
    /// Interaction logic for addMovieDirector.xaml
    /// </summary>
    public partial class addMovieDirector : Window
    {
        baza db;
        List<film> choseMovie;
        List<redatelj> choseGenre;
        public addMovieDirector()
        {
            InitializeComponent();
            db = new baza();
            choseMovie = new List<film>();
            choseGenre = new List<redatelj>();
            choseMovie = db.SelectMovie();
            choseGenre = db.SelectDirector();
            foreach (film f in choseMovie)
            {
                listBoxMovie.Items.Add(f);
            }
            foreach (redatelj z in choseGenre)
            {
                listBoxDirector.Items.Add(z);
            }
        }

        private void btnAddMovieDirector_Click(object sender, RoutedEventArgs e)
        {
            film selectedMovie = (film)listBoxMovie.SelectedItem;
            redatelj selectedGenre = (redatelj)listBoxDirector.SelectedItem;
            string query = "insert into filmzanr  values (" + "'" + selectedMovie.idFilm + "'" + "," + "'" + selectedGenre.idRedatelj + "'" + ")";
            db.insert(query);
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
