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

   
    public partial class admin : Window
    {
        string numberOfClickedButton;
         dataToSend dts;
        //public delegate void sendTableData(object sender, dataToSend e);
        //public event sendTableData selectInfo;
        public admin()
        {
            InitializeComponent();
            
        }

        private void btnAddActor_Click(object sender, RoutedEventArgs e)
        {
            var addActorPanel = new addNewActor();
            addActorPanel.Show();
        }

        private void btnAddAddress_Click(object sender, RoutedEventArgs e)
        {
            var addAddressPanel = new addNewAddress();
            addAddressPanel.Show();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            var addUserPanel = new addNewUser();
            addUserPanel.Show();
        }

        private void bntAddDistributor_Click(object sender, RoutedEventArgs e)
        {
            var addDistributorPanel = new addNewDistributor();
            addDistributorPanel.Show();
        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            var addMoviePanel = new addNewMovie();
            addMoviePanel.Show();
        }

        private void btnAddModel_Click(object sender, RoutedEventArgs e)
        {
            var addModelPanel = new addNewModel();
            addModelPanel.Show();
        }

        private void btnAddNational_Click(object sender, RoutedEventArgs e)
        {
            var addNacionalPanel = new addNewNacional();
            addNacionalPanel.Show();
        }

        private void btnAddDirector_Click(object sender, RoutedEventArgs e)
        {
            var addDirectorPanel = new addNewDirector();
            addDirectorPanel.Show();
        }

        private void btnAddGenre_Click(object sender, RoutedEventArgs e)
        {
            var addGenrePanel = new addNewGenre();
            addGenrePanel.Show();
        }

        private void btnAddTitle_Click(object sender, RoutedEventArgs e)
        {
            var addTitlePanel = new addNewTitle();
            addTitlePanel.Show();
        }

        private void btnAddMemebership_Click(object sender, RoutedEventArgs e)
        {
            var addMembershipPanel = new addNewMembership();
            addMembershipPanel.Show();
        }

        private void btnChangeActor_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "1";
            dts = new dataToSend(numberOfClickedButton, "glumac");
            var aW = new editAll(dts);
            aW.Show();
            //this.Dispose();
        }

        private void btnChangeModel_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "2";
            dts = new dataToSend(numberOfClickedButton, "model");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "3";
            dts = new dataToSend(numberOfClickedButton, "korisnik");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnChangeAddress_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "4";
            dts = new dataToSend(numberOfClickedButton, "adresa");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnChangeMovie_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "5";
            dts = new dataToSend(numberOfClickedButton, "film");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnChangeDistributor_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "6";
            dts = new dataToSend(numberOfClickedButton, "distributer");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnChangeNational_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "7";
            dts = new dataToSend(numberOfClickedButton, "nacionalnost");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void bntChangeDirector_Click(object sender, RoutedEventArgs e)
        {
            numberOfClickedButton = "8";
            dts = new dataToSend(numberOfClickedButton, "redatelj");
            var aW = new editAll(dts);
            aW.Show();
        }

        private void btnAddGenreMovie_Click(object sender, RoutedEventArgs e)
        {
            var ae = new addNewGenreMovie();
            ae.Show();
        }

        private void btnAddMovieActor_Click(object sender, RoutedEventArgs e)
        {
            var ae = new addNewMovieActor();
            ae.Show();
        }

        private void btnAddMovieDirector_Click(object sender, RoutedEventArgs e)
        {
            var ae = new addMovieDirector();
            ae.Show();
        }
    }
}
