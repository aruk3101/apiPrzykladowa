﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace apiPrzykladowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Porada_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var losowaPorada = await Porada.LosujPorade();
                PoradaLabel.Text = $"\"{losowaPorada}\"";
            }
            catch (Exception)
            {
                PoradaLabel.Text = "Blad pobierania cytatu";
            }
        }
    }
}