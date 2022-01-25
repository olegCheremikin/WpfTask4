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

namespace WpfLab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resSum2.Text = resGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resGrivna = rateDrama * sumDrama;
            resSum3.Text = resGrivna.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distanceInch = Convert.ToDouble(distance.Text);
            double distanceMeters = 0.0254 * distanceInch;
            distanceRes.Text = distanceMeters.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distanceFeet = Convert.ToDouble(distance1.Text);
            double distanceMeters = 0.3048 * distanceFeet;
            distanceRes1.Text = distanceMeters.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distanceMiles = Convert.ToDouble(distance2.Text);
            double distanceMeters = 1609.34 * distanceMiles;
            distanceRes2.Text = distanceMeters.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distanceVerst = Convert.ToDouble(distance3.Text);
            double distanceMeters = 1066.8 * distanceVerst;
            distanceRes3.Text = distanceMeters.ToString();
        }
    }
}
