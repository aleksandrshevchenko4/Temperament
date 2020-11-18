using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            //InitializeComponent();
            var holerikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Холерик",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                       { Source = "hol.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                    }
                }
            };
            var sangvinikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Сангвиник",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                       { Source = "sangv.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                    }
                }
            };
            var flegmatikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Флегматик",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                       { Source = "fleg.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                    }
                }
            };
            var melanholikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Меланхолик",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center
                        },
                        new Image
                       { Source = "mel.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                       }
                    }
                }
            };
            Children.Add(holerikContentPage);
            Children.Add(sangvinikContentPage);
            Children.Add(flegmatikContentPage);
            Children.Add(melanholikContentPage);
        }
    }
}
