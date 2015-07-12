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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace evideoteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        baza baza;
        List<korisnik> list;
        String userName, password;
        public MainWindow()
        {
            InitializeComponent();
            baza = new baza();
            
           // list = baza.Select();
          
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            list = baza.Select();
            bool usernotfound = true;
            userName = txtBoxUserName.Text;
            password = passBox.Password;
            foreach (korisnik l in list)
            {
               // MessageBox.Show(l.korisnickoIme);
                if (userName == l.korisnickoIme && password == l.sifra)
                {
                    if (l.tip == 1)
                    {
                        var adminPanel = new admin();
                        adminPanel.Show();
                        usernotfound = false;
                        this.Close();
                        break;
                    }
                    else if (l.tip == 2)
                    {
                        var userPanel = new userMainPanel();
                        userPanel.Show();
                        usernotfound = false;
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Greska!");
                    }
                    
                }
               
            }
            if (usernotfound)
                MessageBox.Show("Korisnik nepostoji u bazi");
        }

        private void txtBoxUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
