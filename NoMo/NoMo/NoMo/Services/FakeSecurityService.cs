
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using NoMo.Enums.Security;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System;

namespace NoMo
{
    public class FakeSecurityService : FlyoutPage
    {
        private List<NoMoFlyout.MenuItem> _menuItems;
        public bool LoggedIn { get; set; }
        

        public FakeSecurityService()
        {
            CreateMenuItems();
        }

        private List<NoMoFlyout.MenuItem> GetAllowedAccessItems()
        {
            if (LoggedIn)
            {
                var accessItems = new List<NoMoFlyout.MenuItem>();

                foreach (var item in _menuItems)
                {
                    if (item.MenuType == MenuTypeEnum.Secured || item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.LogOut)
                    {
                        accessItems.Add(item);
                    }
                }

                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
            else
            {
                var accessItems = new List<NoMoFlyout.MenuItem>();

                foreach (var item in _menuItems)
                {
                    if (item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.Login)
                    {
                        accessItems.Add(item);
                    }
                }

                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
        }
        public bool LogIn()
        {
            // Do Your Stuff to Check if Legit (ie API Calls)

            LoggedIn = true;

            return true;
        }

        public void LogOut()
        {
            LoggedIn = false;
            
        }

        private void CreateMenuItems()
        {
            _menuItems = new List<NoMoFlyout.MenuItem>();

            var menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 1;
            menuItem.MenuItemName = "Awareness";
            menuItem.TargetType = typeof(Awareness);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 1;


            _menuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 2;
            menuItem.MenuItemName = "Support";
            menuItem.TargetType = typeof(SupportMenu);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 2;


            _menuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 3;
            menuItem.MenuItemName = "Legal Education";
            menuItem.TargetType = typeof(LegalEducation);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 3;


            _menuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Motivational Quote";
            menuItem.TargetType = typeof(MotivationalQuotes);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 4;

            _menuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 5;
            menuItem.MenuItemName = "Testimonials";
            menuItem.TargetType = typeof(Testimonials);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 5;

            _menuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 6;
            menuItem.MenuItemName = "Pledge";
            menuItem.TargetType = typeof(Pledge);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 6;
        }

        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private void propertyChanged(FakeSecurityService fakeSecurityService, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            throw new NotImplementedException();
        }

        private void propertyChanged(NoMoFlyout noMoFlyout, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            throw new NotImplementedException();
        }

        private System.Collections.IEnumerable menuItems;

        public System.Collections.IEnumerable MenuItems { get => menuItems; set => SetProperty(ref menuItems, value); }

        private string menuItemName;

        public string MenuItemName { get => menuItemName; set => SetProperty(ref menuItemName, value); }
    }
}
