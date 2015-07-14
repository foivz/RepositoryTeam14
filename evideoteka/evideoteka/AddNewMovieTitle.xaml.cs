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
    /// Interaction logic for AddNewMovieTitle.xaml
    /// </summary>
    public partial class AddNewMovieTitle
    {
        baza db;
        List<film> choseMovie;
        List<titl> choseTitle;

        public AddNewMovieTitle()
        {
            InitializeComponent();
            db = new baza();
            choseMovie = new List<film>();
            choseTitle = new List<titl>();
            choseMovie = db.SelectMovie();
            choseTitle = db.SelectTitle();
            foreach (film f in choseMovie)
            {
                listBoxMovie.Items.Add(f);
            }
            foreach (titl t in choseTitle)
            {
                listBoxTitle.Items.Add(t);
            }
        }

        private void btnAddNewMovieTitle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                film selectedMovie = (film)listBoxMovie.SelectedItem;
                titl selectedTitle = (titl)listBoxTitle.SelectedItem;
                string query = "insert into filmtitl  values (" + "'" + selectedMovie.idFilm + "'" + "," + "'" + selectedTitle.idTitl + "'" + ")";
                db.insert(query);
            }

            catch (Exception)
            {
                MessageBox.Show("Odaberite obje vrijednosti!");

            }
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        }
    }
}
