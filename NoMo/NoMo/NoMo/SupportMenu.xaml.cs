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

        private void TapGestureRecognizer_Tapped_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CapeWinelandsRegion());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CentralKarooRegion());
        }

        private void TapGestureRecognizer_Tapped_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new GardenRouteAndKleinKarooRegion());
        }

        private void TapGestureRecognizer_Tapped_4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new OverbergRegion());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new WestCoastRegion());
        }
    }
}