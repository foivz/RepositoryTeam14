﻿using System;
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
    /// Interaction logic for addNewDistributor.xaml
    /// </summary>
    public partial class addNewDistributor
    {
        baza db;
        string name, address, phone, faks, email, oib;
        public addNewDistributor()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnAddDistributor_Click(object sender, RoutedEventArgs e)
        {
            name = txtBoxName.Text;
            address = txtBoxAddress.Text;
            phone = txtBoxPhone.Text;
            faks = txtBoxFax.Text;
            email = txtBoxEmail.Text;
            oib = txtBoxOib.Text;
            string query = "insert into distributer(naziv, adresa, telefon, faks, email, oib) values ( " + "'" + name + "'" + "," + "'" + address + "'" + "," + "'" + phone + "'" + "," + "'" + faks + "'" + "," + "'" + email + "'" + "," + "'" + oib + "'" + ")";
            db.insert(query);
        }

        private void btnCloseDistributor_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxOib_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBoxOib.Text.Length != 11)
            {

                btnAddDistributor.IsEnabled = false;
                txtBoxOib.BorderBrush = new SolidColorBrush(Colors.Red);
            }

            else
            {
                btnAddDistributor.IsEnabled = true;
                txtBoxOib.BorderBrush = new SolidColorBrush(Colors.Black);

            }
        }
    }
}
