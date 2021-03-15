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

        public new string Title { get; }

        private async void AwarenessClicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Awareness());
        }

        private async void SupportClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupportMenu());
        }


        private async void LegalEducationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegalEducation());
        }


       
    }

}
    


