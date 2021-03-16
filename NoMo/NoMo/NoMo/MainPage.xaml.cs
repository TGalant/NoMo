using System;
using Xamarin.Forms;

namespace NoMo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Title = "NoMo";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Awareness());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupportMenu());
        }

        private async void  Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegalEducation());
        }
    }
}




