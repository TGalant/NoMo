using NoMo.Enums.Security;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace NoMo
{
    public partial class NoMoFlyout : FlyoutPage
    {
        public NoMoFlyout()
        {

            InitializeComponent();

            BindingContext = new FlyoutPageViewModel(Navigation);
        }

        

        
        
    }


}

       
  

 