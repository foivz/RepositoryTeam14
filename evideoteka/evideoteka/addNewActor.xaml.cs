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
    /// Interaction logic for addNewActor.xaml
    /// </summary>
    public partial class addNewActor 
    {
        List<nacionalnost> nacionality;
        string actorName, actorSurname, actorYear;
        baza db;
        public addNewActor()
        {
            InitializeComponent();
            db = new baza();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //actor = new glumac();
            actorName = txtBoxActorName.Text;
            actorSurname = txtBoxActorSurname.Text;
            actorYear = txtBoxActorYear.Text;            
            string query = "insert into glumac(ime, prezime, datumRodjenja) values ( " + "'" + actorName + "'" + "," + "'" + actorSurname + "'" + "," + "'" + actorYear + "'" + " )";
            db.insert(query);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
