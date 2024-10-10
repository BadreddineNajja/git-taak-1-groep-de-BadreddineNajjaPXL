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

namespace PE2_Git_Taak_1
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

        private void Dune2_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                MovieTextBlock.Text = "Dune: Part Two\r\nPaul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.\r\n";
            }
        }

        private void TheSubstance_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                MovieTextBlock.Text = "The Substance\r\nA fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.\r\n";
            }
        }

        private void Furiosa_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                MovieTextBlock.Text = "Furiosa: A Mad Max Saga\r\nThe origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";
            }
        }
    }
}