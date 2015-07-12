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
    /// Interaction logic for userMovieList.xaml
    /// </summary>
    public partial class userMovieList
    {
        baza db;
        List<film> movieList;
        public userMovieList()
        {
            InitializeComponent();
            db = new baza();
            movieList = new List<film>();
            movieList = db.SelectMovie();
            foreach (film f in movieList)
            {
                listBoxMovieList.Items.Add(f);
            }
        }

        private void listBoxMovieList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            film selectedMovie = (film)listBoxMovieList.SelectedItem;
            String path = selectedMovie.putanja;
            var playMovie = new user(path);
            playMovie.Show();

        }
    }
}
