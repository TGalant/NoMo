using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoMo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Testimonials : ContentPage
    {
        public Testimonials()
        {
            InitializeComponent();

            Title = "Testimonials";
        }
    }
}