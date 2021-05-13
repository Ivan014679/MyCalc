using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            oplist.Items.Add("Add");
            oplist.Items.Add("Substract");
            oplist.Items.Add("Multiply");
            oplist.Items.Add("Divide");
        }

        private void OnButtonClicked(object s, EventArgs e)
        {
            String op = oplist.SelectedIndex.ToString();
            int n1 = Int32.Parse(num1.Text);
            int n2 = Int32.Parse(num2.Text);
            double res;


            switch (op)
            {
                case "0":
                    res = n1 + n2;
                    break;
                case "1":
                    res = n1 - n2;
                    break;
                case "2":
                    res = n1 * n2;
                    break;
                case "3":
                    res = n1 / n2;
                    break;
                default:
                    res = 0;
                    break;
            }

            result.Text = res.ToString();
        }
    }
}
