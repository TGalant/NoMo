using System;
using System.Windows.Input;
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupportMenu());
        }
    }

}
