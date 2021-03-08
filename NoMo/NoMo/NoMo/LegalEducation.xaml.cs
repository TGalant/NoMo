using Xamarin.Forms;

namespace NoMo
{
    public partial class LegalEducation : ContentPage
    {
        public LegalEducation()
        {
            InitializeComponent();

            Title = "Legal Education";
        }


        private void TapRecognizer_One(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Laws());
        }

        private void TapRecognizer_Two(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Protocol());
        }
    }
}