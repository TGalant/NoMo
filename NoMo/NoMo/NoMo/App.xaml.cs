using Xamarin.Forms;

namespace NoMo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPageFly;
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
