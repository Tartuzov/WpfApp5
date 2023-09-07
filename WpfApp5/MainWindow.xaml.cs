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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            bool Flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Caps_Click(object sender, RoutedEventArgs e)
        {
            if (!Flag)
            {
                Flag = true;
                Upindex();
            }
            else
            {
                Flag = false;
                Downindex();
            }
        }

        private void Shift_Click(object sender, RoutedEventArgs e)
        {
            if(!Flag)
                Upindex();
            else
                Downindex();
        }
        
        private void Shift_Up(object sender, RoutedEventArgs e)
        {
            if (!Flag)
                Downindex();
            else
                Upindex();
        }
        private void Upindex()
        {

            (k1.Children[0] as Button).Content="~";
            (k1.Children[1] as Button).Content="!";
            (k1.Children[2] as Button).Content="@";
            (k1.Children[3] as Button).Content="#";
            (k1.Children[4] as Button).Content="$";
            (k1.Children[5] as Button).Content="%";
            (k1.Children[6] as Button).Content="^";
            (k1.Children[7] as Button).Content="&";
            (k1.Children[8] as Button).Content="*";
            (k1.Children[9] as Button).Content="(";
            (k1.Children[10] as Button).Content=")";
            (k1.Children[11] as Button).Content="_";
            (k1.Children[12] as Button).Content="+";

            (k2.Children[1] as Button).Content=(k2.Children[1] as Button).Content.ToString().ToUpper();
            (k2.Children[2] as Button).Content=(k2.Children[2] as Button).Content.ToString().ToUpper();
            (k2.Children[3] as Button).Content=(k2.Children[3] as Button).Content.ToString().ToUpper();
            (k2.Children[4] as Button).Content=(k2.Children[4] as Button).Content.ToString().ToUpper();
            (k2.Children[5] as Button).Content=(k2.Children[5] as Button).Content.ToString().ToUpper();
            (k2.Children[6] as Button).Content=(k2.Children[6] as Button).Content.ToString().ToUpper();
            (k2.Children[7] as Button).Content=(k2.Children[7] as Button).Content.ToString().ToUpper();
            (k2.Children[8] as Button).Content=(k2.Children[8] as Button).Content.ToString().ToUpper();
            (k2.Children[9] as Button).Content=(k2.Children[9] as Button).Content.ToString().ToUpper();
            (k2.Children[10] as Button).Content=(k2.Children[10] as Button).Content.ToString().ToUpper();
            (k2.Children[11] as Button).Content="{";
            (k2.Children[12] as Button).Content="}";
            (k2.Children[13] as Button).Content="|";

            (k3.Children[1] as Button).Content = (k3.Children[1] as Button).Content.ToString().ToUpper();
            (k3.Children[2] as Button).Content = (k3.Children[2] as Button).Content.ToString().ToUpper();
            (k3.Children[3] as Button).Content = (k3.Children[3] as Button).Content.ToString().ToUpper();
            (k3.Children[4] as Button).Content = (k3.Children[4] as Button).Content.ToString().ToUpper();
            (k3.Children[5] as Button).Content = (k3.Children[5] as Button).Content.ToString().ToUpper();
            (k3.Children[6] as Button).Content = (k3.Children[6] as Button).Content.ToString().ToUpper();
            (k3.Children[7] as Button).Content = (k3.Children[7] as Button).Content.ToString().ToUpper();
            (k3.Children[8] as Button).Content = (k3.Children[8] as Button).Content.ToString().ToUpper();
            (k3.Children[9] as Button).Content = (k3.Children[9] as Button).Content.ToString().ToUpper();
            (k3.Children[10] as Button).Content = ":";
            (k3.Children[11] as Button).Content = "\"";

            (k4.Children[1] as Button).Content = (k4.Children[1] as Button).Content.ToString().ToUpper();
            (k4.Children[2] as Button).Content = (k4.Children[2] as Button).Content.ToString().ToUpper();
            (k4.Children[3] as Button).Content = (k4.Children[3] as Button).Content.ToString().ToUpper();
            (k4.Children[4] as Button).Content = (k4.Children[4] as Button).Content.ToString().ToUpper();
            (k4.Children[5] as Button).Content = (k4.Children[5] as Button).Content.ToString().ToUpper();
            (k4.Children[6] as Button).Content = (k4.Children[6] as Button).Content.ToString().ToUpper();
            (k4.Children[7] as Button).Content = (k4.Children[7] as Button).Content.ToString().ToUpper();
            (k4.Children[8] as Button).Content ="<";
            (k4.Children[9] as Button).Content = ">";
            (k4.Children[10] as Button).Content = "?";
        }                                         
        private void Downindex()
        {
            (k1.Children[0] as Button).Content = "`";
            (k1.Children[1]  as Button).Content = "1";
            (k1.Children[2]  as Button).Content = "2";
            (k1.Children[3]  as Button).Content = "3";
            (k1.Children[4]  as Button).Content = "4";
            (k1.Children[5]  as Button).Content = "5";
            (k1.Children[6]  as Button).Content = "6";
            (k1.Children[7]  as Button).Content = "7";
            (k1.Children[8]  as Button).Content = "8";
            (k1.Children[9]  as Button).Content = "9";
            (k1.Children[10] as Button).Content = "0";
            (k1.Children[11] as Button).Content = "-";
            (k1.Children[12] as Button).Content = "=";

            (k2.Children[1] as Button).Content = (k2.Children[1] as Button).Content.ToString().ToLower();
            (k2.Children[2] as Button).Content = (k2.Children[2] as Button).Content.ToString().ToLower();
            (k2.Children[3] as Button).Content = (k2.Children[3] as Button).Content.ToString().ToLower();
            (k2.Children[4] as Button).Content = (k2.Children[4] as Button).Content.ToString().ToLower();
            (k2.Children[5] as Button).Content = (k2.Children[5] as Button).Content.ToString().ToLower();
            (k2.Children[6] as Button).Content = (k2.Children[6] as Button).Content.ToString().ToLower();
            (k2.Children[7] as Button).Content = (k2.Children[7] as Button).Content.ToString().ToLower();
            (k2.Children[8] as Button).Content = (k2.Children[8] as Button).Content.ToString().ToLower();
            (k2.Children[9] as Button).Content = (k2.Children[9] as Button).Content.ToString().ToLower();
            (k2.Children[10] as Button).Content = (k2.Children[10] as Button).Content.ToString().ToLower();
            (k2.Children[11] as Button).Content = "[";
            (k2.Children[12] as Button).Content = "]";
            (k2.Children[13] as Button).Content = "\\";

            (k3.Children[1] as Button).Content = (k3.Children[1] as Button).Content.ToString().ToLower();
            (k3.Children[2] as Button).Content = (k3.Children[2] as Button).Content.ToString().ToLower();
            (k3.Children[3] as Button).Content = (k3.Children[3] as Button).Content.ToString().ToLower();
            (k3.Children[4] as Button).Content = (k3.Children[4] as Button).Content.ToString().ToLower();
            (k3.Children[5] as Button).Content = (k3.Children[5] as Button).Content.ToString().ToLower();
            (k3.Children[6] as Button).Content = (k3.Children[6] as Button).Content.ToString().ToLower();
            (k3.Children[7] as Button).Content = (k3.Children[7] as Button).Content.ToString().ToLower();
            (k3.Children[8] as Button).Content = (k3.Children[8] as Button).Content.ToString().ToLower();
            (k3.Children[9] as Button).Content = (k3.Children[9] as Button).Content.ToString().ToLower();
            (k3.Children[10] as Button).Content = ";";
            (k3.Children[11] as Button).Content = "'";

            (k4.Children[1] as Button).Content = (k4.Children[1] as Button).Content.ToString().ToLower();
            (k4.Children[2] as Button).Content = (k4.Children[2] as Button).Content.ToString().ToLower();
            (k4.Children[3] as Button).Content = (k4.Children[3] as Button).Content.ToString().ToLower();
            (k4.Children[4] as Button).Content = (k4.Children[4] as Button).Content.ToString().ToLower();
            (k4.Children[5] as Button).Content = (k4.Children[5] as Button).Content.ToString().ToLower();
            (k4.Children[6] as Button).Content = (k4.Children[6] as Button).Content.ToString().ToLower();
            (k4.Children[7] as Button).Content = (k4.Children[7] as Button).Content.ToString().ToLower();
            (k4.Children[8] as Button).Content = ",";
            (k4.Children[9] as Button).Content = ".";
            (k4.Children[10] as Button).Content = "/";
        }
    }
}
