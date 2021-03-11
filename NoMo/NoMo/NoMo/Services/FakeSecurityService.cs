
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace NoMo
{
    public class FakeSecurityService : FlyoutPage
    {
        private List<NoMoFlyout.MenuItem> _allMenuItems;

        public FakeSecurityService()
        {
            CreateMenuItems();
        }
        private void CreateMenuItems()
        {
            _allMenuItems = new List<NoMoFlyout.MenuItem>();

            var menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 1;
            menuItem.MenuItemName = "Awareness";
            menuItem.TargetType = typeof(Awareness);
            menuItem.MenuOrder = 1;
           

            _allMenuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 2;
            menuItem.MenuItemName = "Support";
            menuItem.TargetType = typeof(SupportMenu);
            menuItem.MenuOrder = 2;
            

            _allMenuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 3;
            menuItem.MenuItemName = "Legal Education";
            menuItem.TargetType = typeof(LegalEducation);
            menuItem.MenuOrder = 3;
            

            _allMenuItems.Add(menuItem);

            menuItem = new NoMoFlyout.MenuItem();
            menuItem.MenuItemId = 4;
            menuItem.MenuItemName = "Motivational Quote";
            menuItem.TargetType = typeof(MotivationalQuotes);
            menuItem.MenuOrder = 4;

            _allMenuItems.Add(menuItem);

            
        }
    }
}
