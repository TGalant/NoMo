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

        public new string Title { get; }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Awareness());
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SupportMenu());
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LegalEducation());
        }
    }
    
}
    


