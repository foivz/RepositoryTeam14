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
    /// Interaction logic for userMainPanel.xaml
    /// </summary>
    public partial class userMainPanel : Window
    {
        public userMainPanel()
        {
            InitializeComponent();
        }

        private void btnMovieList_Click(object sender, RoutedEventArgs e)
        {
            var moviePanel = new userMovieList();
            moviePanel.Show();

        }

        private void btnMoviByGenre_Click(object sender, RoutedEventArgs e)
        {
            var moviePanelGenre = new userMovieGenre();
            moviePanelGenre.Show();
        }

        private void btnMovieSearch_Click(object sender, RoutedEventArgs e)
        {
            var moviPanelSearch = new userMovieSearch();
            moviPanelSearch.Show();
        }
    }
}
