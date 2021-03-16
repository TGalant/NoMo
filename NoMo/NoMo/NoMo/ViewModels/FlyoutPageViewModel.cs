using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using System;
using NoMo.Enums.Security;
using FlyoutMenuExample.Services.Interfaces;

namespace NoMo
{
    public class FlyoutPageViewModel : BaseViewModel
    {
        private ISecurityService _securityService;

        public ICommand NavigateCommand { get; private set; }

        private ObservableCollection<FlyoutMenuExample.Models.Security.MenuItem> _menuItems;

        

        public ObservableCollection<FlyoutMenuExample.Models.Security.MenuItem> MenuItems
        {
            get { return _menuItems; }
            set {
                _menuItems = value; 
                OnPropertyChanged(); }
        }



        public FlyoutPageViewModel(INavigation navigation) : base(navigation)
        {
            _securityService = DependencyService.Get<ISecurityService>();

            NavigateCommand = new Command<FlyoutMenuExample.Models.Security.MenuItem>(ExecuteNavigateCommand);

            var items = _securityService.GetAllowedAccessItems();
            MenuItems = new ObservableCollection<FlyoutMenuExample.Models.Security.MenuItem>((System.Collections.Generic.List<FlyoutMenuExample.Models.Security.MenuItem>)items);
            
            
        }


        private void ExecuteNavigateCommand(FlyoutMenuExample.Models.Security.MenuItem menuItem)
        {
           
            {
                var mainPage = App.Current.MainPage as FlyoutPage;
                if (mainPage != null)
                {
                    var navPage = new NavigationPage((Page)Activator.CreateInstance((Type)menuItem.TargetType));
                    navPage.BarBackgroundColor = Color.FromHex("96989B");
                    mainPage.Detail = navPage; 
                    mainPage.IsPresented = false;
                }
            }
        }
    }
}
