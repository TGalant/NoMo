using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NoMo
{
    public partial class HamburgerMenu : ContentPage
    {

        public HamburgerMenu()
        {
            var hamburgerMenuItems = new List<HamburgerMenuItem>
            {
                new HamburgerMenuItem
                {
                    Title = "Awareness",
                    TargetType = typeof(Awareness)
                },
                new HamburgerMenuItem
                {
                    Title = "Support",
                    TargetType = typeof(SupportMenu)
                }
 
            };

            listView = new ListView
            {
                ItemsSource = hamburgerMenuItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

              
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };

            IconImageSource = "logo.jpg";
            Title = "NoMo";
            Padding = new Thickness(0, 40, 0, 0);
            Content = new StackLayout
            {
                Children = { listView }
            };
        }
    }

    internal class HamburgerMenuItem
    {
        public string Title { get; internal set; }
        public Type TargetType { get; internal set; }
    }
}