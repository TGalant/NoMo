using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using System;
using NoMo.Enums.Security;


namespace NoMo
{
    public class FlyoutPageViewModel : FlyoutPage
    {

        public ICommand NavigateCommand { get; private set; }

        private ObservableCollection<NoMoFlyout.MenuItem> _menuItems;
        private INavigation navigation;

        

        private ObservableCollection<NoMoFlyout.MenuItem> MenuItems
        {
            get { return _menuItems; }
            set {
                _menuItems = value; 
                OnPropertyChanged(); }
        }

        

        public FlyoutPageViewModel(INavigation navigation, NoMoFlyout _menuItems) 
        {
            _menuItems = DependencyService.Get<NoMoFlyout>();

            NavigateCommand = new Command<NoMoFlyout.MenuItem>(ExecuteNavigateCommand);

            var items = _menuItems.GetAllowedAccessItems();
            MenuItems = new ObservableCollection<NoMoFlyout.MenuItem>((System.Collections.Generic.List<NoMoFlyout.MenuItem>)items);
            
            
        }

        public FlyoutPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
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
