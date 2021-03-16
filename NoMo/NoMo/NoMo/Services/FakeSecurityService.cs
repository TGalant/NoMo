using FlyoutMenuExample.Enums.Security;
using FlyoutMenuExample.Messages.Security;
using FlyoutMenuExample.Models.Security;
using FlyoutMenuExample.Services;
using FlyoutMenuExample.Services.Interfaces;
using NoMo;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FlyoutMenuExample.Services
{
    public class FakeSecurityService : ISecurityService
    {
        public IList<Models.Security.MenuItem> _allMenuItems;

        public bool LoggedIn { get; set; }

        public FakeSecurityService()
        {
            CreateMenuItems();
        }

        public IList<Models.Security.MenuItem> GetAllowedAccessItems()
        {
            if (LoggedIn)
            {
                var accessItems = new List<FlyoutMenuExample.Models.Security.MenuItem>();

                foreach (var item in _allMenuItems)
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
                var accessItems = new List<Models.Security.MenuItem>();

                foreach (var item in _allMenuItems)
                {
                    if (item.MenuType == MenuTypeEnum.UnSecured || item.MenuType == MenuTypeEnum.Login)
                    {
                        accessItems.Add(item);
                    }
                }

                return accessItems.OrderBy(x => x.MenuOrder).ToList();
            }
        }

        public bool LogIn(string userName, string password)
        {
            // Do Your Stuff to Check if Legit (ie API Calls)

            LoggedIn = true;

            return true;
        }

        public void LogOut()
        {
            LoggedIn = false;
            MessagingCenter.Send<LogOutMessage>(new LogOutMessage(), "Logout");
        }

        private void CreateMenuItems()
        {
            _allMenuItems = new List<FlyoutMenuExample.Models.Security.MenuItem>();

            var menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 1;
            menuItem.MenuItemName = "Awareness";
            menuItem.TargetType = typeof(Awareness);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 1;


            _allMenuItems.Add(menuItem);

            menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 2;
            menuItem.MenuItemName = "Support";
            menuItem.TargetType = typeof(SupportMenu);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 2;


            _allMenuItems.Add(menuItem);

            menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 3;
            menuItem.MenuItemName = "Legal Education";
            menuItem.TargetType = typeof(LegalEducation);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 3;


            _allMenuItems.Add(menuItem);

            menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Motivational Quote";
            menuItem.TargetType = typeof(MotivationalQuotes);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 4;

            _allMenuItems.Add(menuItem);

            menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 5;
            menuItem.MenuItemName = "Testimonials";
            menuItem.TargetType = typeof(Testimonials);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 5;

            _allMenuItems.Add(menuItem);

            menuItem = new FlyoutMenuExample.Models.Security.MenuItem();
            menuItem.MenuItemId = 6;
            menuItem.MenuItemName = "Pledge";
            menuItem.TargetType = typeof(Pledge);
            menuItem.MenuType = MenuTypeEnum.UnSecured;
            menuItem.MenuOrder = 6;

            _allMenuItems.Add(menuItem);
        }
    }
}
