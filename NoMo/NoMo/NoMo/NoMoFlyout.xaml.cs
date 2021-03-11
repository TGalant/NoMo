using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace NoMo
{
    public partial class NoMoFlyout : FlyoutPage
    {
        public NoMoFlyout()
        {

            InitializeComponent();

            BindingContext = new FlyoutPageViewModel(Navigation);
        }

        internal class MenuItem
        {
            public object MenuType { get; internal set; }
            public object TargetType { get; internal set; }
            public int MenuItemId { get; internal set; }
            public string MenuItemName { get; internal set; }
            public int MenuOrder { get; internal set; }
        }

        internal object GetAllowedAccessItems()
        {
            throw new NotImplementedException();
        }
    }


}

       
  

 