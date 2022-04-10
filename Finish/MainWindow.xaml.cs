using System;
using System.Data;
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

namespace Finish
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement button in MainGrid.Children)
            {
                if (button is Button)
                {
                    ((Button)button).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = (string)((Button)sender).Content;

            if (value == "C")
            {
                textBox.Text = "";
            }
            else
            {
                if (value == "=")
                {
                    string result = new DataTable().Compute(textBox.Text, null).ToString();
                    textBox.Text = result;
                }
                else
                {
                    if (value == "<=")
                    {
                        string var = textBox.Text;
                        var = var.Remove(var.Length - 1);
                        textBox.Text = var;
                    }
                    else
                        textBox.Text += value;
                }
            }
        }
    }
 }
