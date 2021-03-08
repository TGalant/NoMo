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

        private async System.Threading.Tasks.Task Button_ClickedAsync(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new Awareness());
        }

        private async System.Threading.Tasks.Task Button_Clicked_1Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SupportMenu());
        }


        private async System.Threading.Tasks.Task Button_Clicked_2Async(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LegalEducation());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }

}
    


