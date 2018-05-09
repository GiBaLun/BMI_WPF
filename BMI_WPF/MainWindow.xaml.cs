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

namespace BMI_WPF
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void highclear_Click(object sender, RoutedEventArgs e)
        {
            highnumber.Text = "";
            highbar.Value = 0;
        }

        private void weightclear_Click(object sender, RoutedEventArgs e)
        {
            weightnumber.Text = "";
            weightbar.Value = 0;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value1 = Math.Round(highbar.Value, 1);
            highnumber.Text = value1.ToString();

            Canvas.SetLeft(highborder, (value1 * 2));

            double value2 = Math.Round(weightbar.Value, 1);
            weightnumber.Text = value2.ToString();

            Canvas.SetLeft(weightborder, (value2 * 2.4));

            double highmove = 350 - double.Parse(highnumber.Text);

            double High = double.Parse(highnumber.Text);
            double Weight = double.Parse(weightnumber.Text);
            double BMI;
            BMI = Weight / ((High / 100) * (High / 100));

            answer.Text = BMI.ToString("f1");
        }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            int High = int.Parse(highnumber.Text);
            int Weight = int.Parse(weightnumber.Text);
            int BMI;
            BMI = Weight / ((High / 100) * (High / 100));

            answer.Text = BMI.ToString("f1");
        }
    }
}
