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

namespace WpfApp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = Convert.ToDouble(txtweight.Text);
            double height = Convert.ToDouble(txtheight.Text);
            double result;

            result = weight / (height * height);
            result = result * 1000;
            txtresult.Text = "Your BMI is : "+ result.ToString("#.#");
            
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            txtweight.Text = string.Empty;
            txtheight.Text = string.Empty;
            txtresult.Text = string.Empty;
        }

        
    }
}
