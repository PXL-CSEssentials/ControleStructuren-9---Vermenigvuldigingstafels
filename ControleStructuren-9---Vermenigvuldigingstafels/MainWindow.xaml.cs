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

namespace ControleStructuren_9___Vermenigvuldigingstafels
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "De Tafels van vermenigvuldiging:\r\n\r\n";
            const int StartNumber = 1;
            const int EndNumber = 12;

            for (int i = StartNumber; i <= EndNumber; i++)
            {
                for (int j = StartNumber; j <= EndNumber; j++)
                {
                    resultTextBox.Text += $"{i} * {j} = {i * j}\r\n";
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
