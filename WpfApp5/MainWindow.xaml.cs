using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
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
        string Alltext = "";
        bool Flag = false;
        int erors = 0;
        int cl = 1;
        bool b;
        bool shift = false;
        Stopwatch stopwatch = new Stopwatch();
        public MainWindow()
        {
            InitializeComponent();
            grid1.Focus();
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
            if (!Flag)
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

            (k1.Children[0] as Button).Content = "~";
            (k1.Children[1] as Button).Content = "!";
            (k1.Children[2] as Button).Content = "@";
            (k1.Children[3] as Button).Content = "#";
            (k1.Children[4] as Button).Content = "$";
            (k1.Children[5] as Button).Content = "%";
            (k1.Children[6] as Button).Content = "^";
            (k1.Children[7] as Button).Content = "&";
            (k1.Children[8] as Button).Content = "*";
            (k1.Children[9] as Button).Content = "(";
            (k1.Children[10] as Button).Content = ")";
            (k1.Children[11] as Button).Content = "_";
            (k1.Children[12] as Button).Content = "+";

            (k2.Children[1] as Button).Content = (k2.Children[1] as Button).Content.ToString().ToUpper();
            (k2.Children[2] as Button).Content = (k2.Children[2] as Button).Content.ToString().ToUpper();
            (k2.Children[3] as Button).Content = (k2.Children[3] as Button).Content.ToString().ToUpper();
            (k2.Children[4] as Button).Content = (k2.Children[4] as Button).Content.ToString().ToUpper();
            (k2.Children[5] as Button).Content = (k2.Children[5] as Button).Content.ToString().ToUpper();
            (k2.Children[6] as Button).Content = (k2.Children[6] as Button).Content.ToString().ToUpper();
            (k2.Children[7] as Button).Content = (k2.Children[7] as Button).Content.ToString().ToUpper();
            (k2.Children[8] as Button).Content = (k2.Children[8] as Button).Content.ToString().ToUpper();
            (k2.Children[9] as Button).Content = (k2.Children[9] as Button).Content.ToString().ToUpper();
            (k2.Children[10] as Button).Content = (k2.Children[10] as Button).Content.ToString().ToUpper();
            (k2.Children[11] as Button).Content = "{";
            (k2.Children[12] as Button).Content = "}";
            (k2.Children[13] as Button).Content = "|";

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
            (k4.Children[8] as Button).Content = "<";
            (k4.Children[9] as Button).Content = ">";
            (k4.Children[10] as Button).Content = "?";
        }
        private void Downindex()
        {
            (k1.Children[0] as Button).Content = "`";
            (k1.Children[1] as Button).Content = "1";
            (k1.Children[2] as Button).Content = "2";
            (k1.Children[3] as Button).Content = "3";
            (k1.Children[4] as Button).Content = "4";
            (k1.Children[5] as Button).Content = "5";
            (k1.Children[6] as Button).Content = "6";
            (k1.Children[7] as Button).Content = "7";
            (k1.Children[8] as Button).Content = "8";
            (k1.Children[9] as Button).Content = "9";
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fail.Text = "Fails 0";
            speed.Text = "Speed: 0 chars/min";
            stopwatch.Start();
            if (cl == 5)
                text.Text = "Phasellus tincidunt dignissim tempor. Quisque lacinia congue dui eu viverra. Aenean egestas, nisl vel consectetur mattis, metus nulla ultricies sapien, ac pellentesque arcu ligula id enim. Vestibulum eget placerat leo. Aenean iaculis massa et nisi pretium, non fringilla ipsum consectetur. Donec est elit, interdum sit amet purus sit amet, tincidunt pellentesque elit. In egestas arcu quam, ut tincidunt massa mattis scelerisque. Quisque id scelerisque felis, nec consectetur libero. Aliquam eget ultrices augue, a mollis mi. Mauris consectetur, sapien a vulputate hendrerit, odio nibh interdum metus, a congue sem nunc vel massa. Nunc volutpat lacus eget imperdiet egestas.";
            else if (cl == 1)
                text.Text = "Pellentesque sit amet odio nec purus convallis molestie a ac orci. Aenean ullamcorper consequat neque, in consectetur felis accumsan vitae.";
            else if (cl == 2)
                text.Text = "Nam imperdiet et erat sagittis aliquam. Cras imperdiet sapien ut lobortis varius. Mauris ut ex diam. Aenean varius ante a congue bibendum. Curabitur risus dolor, tristique a auctor ut, imperdiet id neque. Donec ultrices auctor felis ut placerat. Sed pharetra tempus leo nec vulputate.";
            else if (cl == 3)
                text.Text = "Proin neque neque, viverra ac enim ut, vestibulum condimentum ante. Ut eget libero posuere, mattis tellus sit amet, posuere turpis. Aliquam molestie, eros quis efficitur pulvinar, leo dolor sodales magna, quis ornare odio leo in quam. Nulla facilisi. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Maecenas mattis congue ipsum quis egestas.";
            else if (cl == 4)
                text.Text = "Nulla sit amet quam auctor, efficitur dui at, consequat velit. Nunc ut magna tortor. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla accumsan at sem ut malesuada. Aliquam vitae dapibus sem. Ut vehicula vitae ipsum id sodales. Vivamus eu diam eget libero rutrum viverra. Quisque semper odio vel nisi placerat, eu pharetra eros cursus. Proin eget eleifend libero. Pellentesque maximus nulla et fermentum egestas. Vivamus ex risus, semper ut lobortis vel, condimentum a tortor. Etiam at diam vel orci interdum hendrerit nec a nunc. Suspendisse potenti.";
        }
        public void Check(char a)
        {
            if (a == text.Text[Alltext.Count()])
            {
                Alltext += a;
                text.Focus();
                text.SelectionBrush = Brushes.Green;
                text.Select(Alltext.Count() - 1, 1);
            }
            else
            {
                Alltext += a;
                erors += 1;
                fail.Text = $"Fails {erors}";
                text.Focus();
                text.SelectionBrush = Brushes.Red;
                text.Select(Alltext.Count() - 1, 1);
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
            {
                Button button = sender as Button;
                if (button.Content.ToString() == "Space")
                    Check(' ');
                else
                    Check(button.Content.ToString()[0]);
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Alltext.Count() > 0)
                Alltext = Alltext.Remove(Alltext.Length - 1);
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (text.Text == "")
            {
                dif.Text = $"Difficult: {slider.Value + 1}";
                cl = (int)slider.Value + 1;
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            stopwatch.Stop();
            double a = stopwatch.Elapsed.TotalSeconds;
            speed.Text = $"Speed: {Alltext.Count() / a} chars/min";
            text.Clear();
            erors = 0;
            Alltext = "";
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            k4.Focus();
            if (Keyboard.IsKeyDown(Key.CapsLock))
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
            else if (!Keyboard.IsKeyDown(Key.CapsLock) && Keyboard.Modifiers != ModifierKeys.Windows && Keyboard.Modifiers != ModifierKeys.Control && Keyboard.Modifiers != ModifierKeys.Alt)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                    if (Keyboard.Modifiers == ModifierKeys.Shift && e.Key != Key.LeftShift)
                    {
                        Key a = e.Key;
                        Check(a.ToString()[0]);
                    }
                    else { }
                else 
                {
                    Key a = e.Key;
                    if(Flag)
                        Check(a.ToString()[0]);
                    else
                        Check(a.ToString().ToLower()[0]);
                }
            }
        }
        private void grid1_KeyUp(object sender, KeyEventArgs e)
        {
            sp1.Focus();
        }
        private void grid1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Shift)
            {
                shift = true;
                if (!Flag)
                    Upindex();
                else
                    Downindex();
            }
            else if (Keyboard.IsKeyDown(Key.Space)) { 
                Key a = e.Key;
                if (a.ToString() == "Space")
                    Check(' ');
            }
        }

        private void grid1_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (!Flag)
                Downindex();
            else
                Upindex();
            shift = false;

        }
    }
}
