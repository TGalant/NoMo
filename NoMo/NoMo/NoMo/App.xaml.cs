﻿using Xamarin.Forms;

namespace NoMo
{
    public partial class App : Application
    {
        public App()
        {

            MainPage = new NavigationPage(new MainPage());

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
