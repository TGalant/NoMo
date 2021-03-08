using System;
using Xamarin.Forms;


namespace NoMo
{
    public partial class NoMoFlyout : FlyoutPage
    {
        public NoMoFlyout()
        {


            MainPageFly.ListView.ItemSelected += OnItemSelected;

            
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainPageFly;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance((Type)item.TargetType));
               MainPageFly.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
 