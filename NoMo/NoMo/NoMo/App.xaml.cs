using Xamarin.Forms;

namespace NoMo
{
    public partial class App : Application
    {
        public App()
        {

            MainPage = new HamburgerMenu.MainPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
