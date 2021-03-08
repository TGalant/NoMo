using Xamarin.Forms;

namespace NoMo
{
    public partial class SupportMenu : ContentPage
    {
        public SupportMenu()
        {
            InitializeComponent();

            Title = "Support";
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CapePeninsulaRegion());
        }
    }
}