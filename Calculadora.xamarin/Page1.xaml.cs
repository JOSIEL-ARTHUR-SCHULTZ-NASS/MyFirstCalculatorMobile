using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                int[] test = {
                    int.Parse(NumberEntry.Text),
                int.Parse(NumberEntry.Text) * 2,
                int.Parse(NumberEntry.Text)*3,
                int.Parse(NumberEntry.Text)*4,
                int.Parse(NumberEntry.Text)*5,
                int.Parse(NumberEntry.Text)*6,
                int.Parse(NumberEntry.Text)*7,
                int.Parse(NumberEntry.Text)*8,
                int.Parse(NumberEntry.Text)*9,
                int.Parse(NumberEntry.Text)*10
                };
                string[] itemsModfied =
                {
                    NumberEntry.Text + " X 1 = " +test[0].ToString(),
                    NumberEntry.Text + " X 2 = " +test[1].ToString(),
                    NumberEntry.Text + " X 3 = " +test[2].ToString(),
                    NumberEntry.Text + " X 4 = " +test[3].ToString(),
                    NumberEntry.Text + " X 5 = " +test[4].ToString(),
                    NumberEntry.Text + " X 6 = " +test[5].ToString(),
                    NumberEntry.Text + " X 7 = " +test[6].ToString(),
                    NumberEntry.Text + " X 8 = " +test[7].ToString(),
                    NumberEntry.Text + " X 9 = " +test[8].ToString(),
                    NumberEntry.Text + " X 10 = " +test[9].ToString(),
                };
                list.ItemsSource = itemsModfied;
            }
            catch
            {

            }
        }

        async private void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}