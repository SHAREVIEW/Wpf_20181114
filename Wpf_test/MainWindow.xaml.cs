using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

            double a, k;
            a = double.TryParse(textbox1.Text);
            //int.TryParse( textBox1.Text, out a );
            textbox4.Text = (a / k).ToString("000.00000");

         
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox2.Text == "" || double.TryParse(textbox2.Text) == 0)
            {
                textbox4.Text = "";
            }
            else
            {
                double a, k;
                k = double.TryParse(textbox2.Text);
                //int.TryParse( textBox2.Text, out k );
                textbox4.Text = (a / k).ToString("000.00000");
            }
        
        }
    }
}
