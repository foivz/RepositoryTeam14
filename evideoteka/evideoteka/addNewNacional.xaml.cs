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
    /// Interaction logic for addNewNacional.xaml
    /// </summary>
    public partial class addNewNacional
    {
        baza db;
        String name;
        public addNewNacional()
        {
            InitializeComponent();
            db = new baza();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddNacionalnost_Click(object sender, RoutedEventArgs e)
        {

            name = txtBoxNacionalnost.Text;
            string query = "insert into nacionalnost(drzavljanstvo) values ( " + "'" + name + "'" + ")";
            db.insert(query);
        }
    }
}
