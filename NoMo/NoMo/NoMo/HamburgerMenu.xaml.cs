using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace NoMo
{
    public partial class HamburgerMenu : MainPage
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
                },
                new HamburgerMenuItem
                {
                    Title = "Legal Education",
                    TargetType = typeof(LegalEducation)
                },
                new HamburgerMenuItem
                {
                    Title = "Motivational Quotes",
                    TargetType = typeof(MotivationalQuotes)
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

        }

        public HamburgerMenu(ListView listView, FlyoutPage NoMo)
        {
            this.listView = listView;
        }

        internal class MainPage : Page
        {
        }
    }

    internal class HamburgerMenuItem
    {
        public string Title { get; internal set; }
        public Type TargetType { get; internal set; }
    }

}