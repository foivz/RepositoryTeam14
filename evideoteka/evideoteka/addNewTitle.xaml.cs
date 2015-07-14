using Microsoft.Win32;
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
    /// Interaction logic for addNewTitle.xaml
    /// </summary>
    public partial class addNewTitle
    {
        baza db;
        String name, path;
        public addNewTitle()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddTitle_Click(object sender, RoutedEventArgs e)
        {
            name = txtBoxName.Text;
            string query = "insert into titl(jezik, putanja) values ( " + "'" + name + "'" + "," + "'" + path + "'" + ")";
            string query2 = query.Replace(@"\", @"\\");
            db.insert(query2);
        }

        private void btnFindTitle_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog fd = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = fd.ShowDialog();
            if (result == true)
            {
                path = fd.FileName;
            }
        }
    }
}
