
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using System;


namespace NoMo
{
    public class FlyoutPageViewModel : FlyoutPage
    {

        public ICommand NavigateCommand { get; private set; }

        private ObservableCollection<NoMoFlyout.MenuItem> _menuItems;
        private INavigation navigation;

        public FlyoutPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        private ObservableCollection<NoMoFlyout.MenuItem> MenuItem
        {
            get { return _menuItems; }
            set {
                _menuItems = value; 
                OnPropertyChanged(); }
        }
        

        private void ExecuteNavigateCommand(NoMoFlyout.MenuItem menuItem)
        {
           
            {
                var mainPage = App.Current.MainPage as FlyoutPage;
                if (mainPage != null)
                {
                    mainPage.Detail = new NavigationPage((Page)Activator.CreateInstance((Type)menuItem.TargetType));
                    mainPage.IsPresented = false;
                }
            }
        }
    }
}
