﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using TeamManager.Controller;
using TeamManager.View.ViewModel;

namespace TeamManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client;
        public MainWindow()
        {
            client = new HttpClient();
            InitializeComponent();
         
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void txbNome_TextChanged()
        {

        }
    }
}
