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

namespace BarcodeScanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String content = null; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButtonClick(object sender, RoutedEventArgs e)
        {
            content = "Wysłano kod: " + BarCodeTextBox.Text;
            MessageBox.Show(content);
            BarCodeTextBox.Text = "";
            BarCodeTextBox.Focus();
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            BarCodeTextBox.Text = "";
            BarCodeTextBox.Focus();
        }


        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            BarCodeTextBox.Focus();
            
        }
    }
}
