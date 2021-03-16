using FlyoutMenuExample.Services;
using FlyoutMenuExample.Services.Interfaces;
using Xamarin.Forms;

namespace NoMo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var service = new FakeSecurityService();
            DependencyService.RegisterSingleton<ISecurityService>(service);

            MainPage = new NoMoFlyout();
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
