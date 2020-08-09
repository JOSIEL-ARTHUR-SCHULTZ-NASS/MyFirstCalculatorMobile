using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Calculadora.xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        double n1, n2, res; char MathOperator;
        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text += ((Button)sender).Text;
            
        }
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            n2 = double.Parse(label.Text);
            switch (MathOperator)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                case '/':
                    res = n1 / n2;
                    break;
                
            }
            label.Text = string.Empty;
            label.Text = Convert.ToString(res);
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
                    
        }

        async private void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

       

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label.Text = string.Empty;
            n1 = n2 = res = 0;
           
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            try
            {
                n1 = double.Parse(label.Text);
                MathOperator = Convert.ToChar(((Button)sender).Text);
                label.Text = string.Empty;
            }
            catch
            {

            }
        }
    }
}
