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
    /// Interaction logic for admin.xaml
    /// </summary>


    public partial class admin
    {
        string numberOfSelectedItem;
        dataToSend dts;
        public admin()
        {
            InitializeComponent();

        }

        private void mnuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mnuItemAddDistributor_Click(object sender, RoutedEventArgs e)
        {
            var addDistributorPanel = new addNewDistributor();
            addDistributorPanel.ShowDialog();
        }

        private void mnuItemChangeDistributor_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "6";
            dts = new dataToSend(numberOfSelectedItem, "distributer");
            var aW = new editAll(dts);
            aW.ShowDialog();
        }

        private void mnuItemAddAdress_Click(object sender, RoutedEventArgs e)
        {
            var addAddressPanel = new addNewAddress();
            addAddressPanel.ShowDialog();
        }

        private void mnuItemChangeAdress_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "4";
            dts = new dataToSend(numberOfSelectedItem, "adresa");
            var aW = new editAll(dts);
            aW.ShowDialog();

        }

        private void mnuItemAddUser_Click(object sender, RoutedEventArgs e)
        {
            var addUserPanel = new addNewUser();
            addUserPanel.ShowDialog();
        }

        private void mnuItemChangeUser_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "3";
            dts = new dataToSend(numberOfSelectedItem, "korisnik");
            var aW = new editAll(dts);
            aW.ShowDialog();

        }

        private void mnuItemAddModel_Click(object sender, RoutedEventArgs e)
        {
            var addModelPanel = new addNewModel();
            addModelPanel.ShowDialog();
        }

        private void mnuItemChangeModel_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "2";
            dts = new dataToSend(numberOfSelectedItem, "model");
            var aW = new editAll(dts);
            aW.ShowDialog();
        }

        private void mnuItemAddMovie_Click(object sender, RoutedEventArgs e)
        {
            var addMoviePanel = new addNewMovie();
            addMoviePanel.ShowDialog();
        }

        private void mnuItemChangeMovie_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "5";
            dts = new dataToSend(numberOfSelectedItem, "film");
            var aW = new editAll(dts);
            aW.ShowDialog();
        }

        private void mnuItemAddTitle_Click(object sender, RoutedEventArgs e)
        {
            var addTitlePanel = new addNewTitle();
            addTitlePanel.ShowDialog();

        }

        private void mnuItemAddActor_Click(object sender, RoutedEventArgs e)
        {
            var addActorPanel = new addNewActor();
            addActorPanel.ShowDialog();
        }

        private void mnuItemChangeActor_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "1";
            dts = new dataToSend(numberOfSelectedItem, "glumac");
            var aW = new editAll(dts);
            aW.ShowDialog();
            //this.Dispose();
        }

        private void mnuItemAddDirector_Click(object sender, RoutedEventArgs e)
        {
            var addDirectorPanel = new addNewDirector();
            addDirectorPanel.ShowDialog();
        }

        private void mnuItemChangeDirector_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "8";
            dts = new dataToSend(numberOfSelectedItem, "redatelj");
            var aW = new editAll(dts);
            aW.ShowDialog();
        }

        private void mnuItemAddGenre_Click(object sender, RoutedEventArgs e)
        {
            var addGenrePanel = new addNewGenre();
            addGenrePanel.ShowDialog();

        }

        private void mnuItemAddNational_Click(object sender, RoutedEventArgs e)
        {
            var addNacionalPanel = new addNewNacional();
            addNacionalPanel.ShowDialog();

        }

        private void mnuItemChangeNational_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "7";
            dts = new dataToSend(numberOfSelectedItem, "nacionalnost");
            var aW = new editAll(dts);
            aW.ShowDialog();

        }

        private void mnuItemChangeGenre_Click(object sender, RoutedEventArgs e)
        {
            numberOfSelectedItem = "9";
            dts = new dataToSend(numberOfSelectedItem, "zanr");
            var aW = new editAll(dts);
            aW.ShowDialog();

        }

        private void mnuItemAddMovieActor_Click(object sender, RoutedEventArgs e)
        {
            var addMovieActorPanel = new addNewMovieActor();
            addMovieActorPanel.ShowDialog();
        }

        private void mnuItemAddMovieDirector_Click(object sender, RoutedEventArgs e)
        {
            var addMovieDirectorPanel = new addMovieDirector();
            addMovieDirectorPanel.ShowDialog();
        }

        private void mnuItemAddMovieGenre_Click(object sender, RoutedEventArgs e)
        {
            var addMovieGenrePanel = new addNewGenreMovie();
            addMovieGenrePanel.ShowDialog();
        }

        private void mnuItemAddMovieTitle_Click(object sender, RoutedEventArgs e)
        {
            var addMovieSubtitlePanel = new  AddMovieSubtitle();
            addMovieSubtitlePanel.ShowDialog();
        }


    }
}
