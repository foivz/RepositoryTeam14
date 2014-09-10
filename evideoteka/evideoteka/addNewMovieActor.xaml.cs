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
    /// Interaction logic for addNewMovieActor.xaml
    /// </summary>
    public partial class addNewMovieActor : Window
    {
        baza db;
        List<film> choseMovie;
        List<glumac> choseGenre;
        public addNewMovieActor()
        {
            InitializeComponent();
            db = new baza();
            choseMovie = new List<film>();
            choseGenre = new List<glumac>();
            choseMovie = db.SelectMovie();
            choseGenre = db.SelectActor();
            foreach (film f in choseMovie)
            {
                listBoxMovie.Items.Add(f);
            }
            foreach (glumac z in choseGenre)
            {
                listBoxActor.Items.Add(z);
            }
        }

        private void btnAddMovieActor_Click(object sender, RoutedEventArgs e)
        {
            film selectedMovie = (film)listBoxMovie.SelectedItem;
            glumac selectedGenre = (glumac)listBoxActor.SelectedItem;
            string query = "insert into filmzanr  values (" + "'" + selectedMovie.idFilm + "'" + "," + "'" + selectedGenre.idGlumac + "'" + ")";
            db.insert(query);
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
