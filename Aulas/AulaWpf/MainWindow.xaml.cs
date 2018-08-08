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

namespace AulaWpf {
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }//F7 e SHIFT + F7

        public String num1, num2, op, resp;

        private void Button_Click(object sender, RoutedEventArgs e) {
            txtVisor.Text = "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            txtVisor.Text = "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            txtVisor.Text = "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            txtVisor.Text = "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            txtVisor.Text = "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            txtVisor.Text = "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {
            txtVisor.Text = "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) {
            txtVisor.Text = "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) {
            txtVisor.Text = "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) {
            txtVisor.Text = "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) {
            txtVisor.Text = "*";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) {
            txtVisor.Text = "/";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) {
            txtVisor.Text = "-";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) {
            txtVisor.Text = "+";
        }

        private void txtVisor_TextChanged(object sender, TextChangedEventArgs e) {
            num1 = txtVisor.Text;
            op = txtVisor.Text;
            num2 = txtVisor.Text;

        }

        private void Button_Click_14(object sender, RoutedEventArgs e) {
            switch (op) {
                case "*" :
                    resp = num1 * num2;
                    break;

                default:
                    break;
            }
        }

        //img.Source = new BitmapImage(new Uri(@"C:\Users\1617156\Desktop\dev.png"));


    }
}
