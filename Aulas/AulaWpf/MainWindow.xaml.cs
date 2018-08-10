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
        public double num = 0;
        public MainWindow() {
            InitializeComponent();
        }//F7 e SHIFT + F7

        public double acumula;
        public double num1, num2, resp, aux;
        public String op;

        private void Button_Click(object sender, RoutedEventArgs e) {
            num = 1;
            txtVisor.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            num = 2;
            txtVisor.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            num = 3;
            txtVisor.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            num = 4;
            txtVisor.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            num = 5;
            txtVisor.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) {
            num = 6;
            txtVisor.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) {
            num = 7;
            txtVisor.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) {
            num = 8;
            txtVisor.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) {
            num = 9;
            txtVisor.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) {
            num = 0;
            txtVisor.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) {
            //txtVisor.Text += "*";
            /*if (op == "-" || op == "+" || op == "/") {
                op = "*";
            } else {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                op = "*";
            }*/
            //acumula = double.Parse(txtVisor.Text);
            num1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
            op = "*";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e) {
            //txtVisor.Text += "/";
            /*if (op == "*" || op == "+" || op == "-") {
                op = "/";
            } else {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                op = "/";
            }*/
            num1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
            op = "/";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e) {
            //txtVisor.Text += "-";
            /*if (op == "*" || op == "+" || op == "/") {
                op = "-";
            } else {
                acumula = double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                op = "-";
            }*/
            num1 = double.Parse(txtVisor.Text);
            txtVisor.Text = "";
            op = "-";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e) {
            //txtVisor.Text += "+";
            /*if (op == "*" || op == "-" || op == "/") {
                op = "+";
            } else {
                acumula += double.Parse(txtVisor.Text);
                txtVisor.Text = "";
                op = "+";
            }*/
            num1 += double.Parse(txtVisor.Text);
            txtVisor.Text = "";
            op = "+";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e) {
            //=
            aux = resp;
            num2 = double.Parse(txtVisor.Text);
            switch (op) {
                case "+":
                    //acumula += double.Parse(txtVisor.Text); -= *= /=
                    //txtVisor.Text = acumula.ToString();
                    resp = num1 + num2;
                    txtVisor.Text = resp.ToString();
                    break;
                case "-":
                    resp = num1 - num2;
                    txtVisor.Text = resp.ToString();
                    break;
                case "*":
                    resp = num1 * num2;
                    txtVisor.Text = resp.ToString();
                    break;
                case "/":
                    resp = num1 / num2;
                    txtVisor.Text = resp.ToString();
                    break;
            }
            /*if (op == "+") {
                acumula += double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
            } else if (op == "-") {
                acumula -= double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
            } else if (op == "*") {
                acumula *= double.Parse(txtVisor.Text);
                txtVisor.Text = acumula.ToString();
            } else if (op == "/") {
                if (double.Parse(txtVisor.Text) != 0) {
                    acumula /= double.Parse(txtVisor.Text);
                    txtVisor.Text = acumula.ToString();
                } else {
                    txtVisor.Text = "Dividindo por zero";
                }
            }*/
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {// C
            acumula = 0;
            txtVisor.Text = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            txtVisor.Text = aux.ToString();
        }

        private void txtVisor_TextChanged(object sender, TextChangedEventArgs e) {

            /*num1 = txtVisor.Text;
            op = txtVisor.Text;
            num2 = txtVisor.Text;*/

        }

        private void Button_Click_14(object sender, RoutedEventArgs e) {
            // =
            switch (op) {
                //Select Case btn.Content.ToString();
                case "*":
                    resp = num1 * num2;
                    break;

                default:
                    break;
            }
        }

        //img.Source = new BitmapImage(new Uri(@"C:\Users\1617156\Desktop\dev.png"));


    }
}
