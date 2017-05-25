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

namespace Battleship
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

        private void Button_ClickAlpha(object sender, RoutedEventArgs e)
        {
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;s
            Juliet.Visibility = Visibility.Hidden;
        }

        private void Button_ClickBeta(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickCharlie(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickDelta(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickEcho(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickFoxtrot(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickGamma(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickHotel(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickIndego(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Juliet.Visibility = Visibility.Hidden;
        }
        private void Button_ClickJuliet(object sender, RoutedEventArgs e)
        {
            Alpha.Visibility = Visibility.Hidden;
            Beta.Visibility = Visibility.Hidden;
            Charlie.Visibility = Visibility.Hidden;
            Delta.Visibility = Visibility.Hidden;
            Echo.Visibility = Visibility.Hidden;
            Foxtrot.Visibility = Visibility.Hidden;
            Gamma.Visibility = Visibility.Hidden;
            Hotel.Visibility = Visibility.Hidden;
            Indego.Visibility = Visibility.Hidden;
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button10.Visibility = Visibility.Hidden;
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
        }
    }
}
