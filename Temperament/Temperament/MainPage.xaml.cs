using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Temperament
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                BackgroundColor = Color.Gray,
                Text = "Тест",


            };
            Button btn1 = new Button
            {
                BackgroundColor = Color.Gray,
                Text = "Тест",


            };
            Button btn2 = new Button
            {
                BackgroundColor = Color.Gray,
                Text = "Тест",


            };
            Button btn3 = new Button
            {
                BackgroundColor = Color.Gray,
                Text = "Тест",
            };

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
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
                       },
                        btn
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
                        {
                            Source = "sangv.jpg",
                            WidthRequest = 400,
                            HeightRequest = 400,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        },
                        btn1
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
                       },
                        btn2
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
                       },
                        btn1
                    }
                }
            };
            Children.Add(holerikContentPage);
            Children.Add(sangvinikContentPage);
            Children.Add(flegmatikContentPage);
            Children.Add(melanholikContentPage);
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://temperamenttest.org/ru-ru/#start");
            await Browser.OpenAsync(uri);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://temperamenttest.org/ru-ru/#start");
            await Browser.OpenAsync(uri);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://temperamenttest.org/ru-ru/#start");
            await Browser.OpenAsync(uri);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://temperamenttest.org/ru-ru/#start");
            await Browser.OpenAsync(uri);
        }
    }
}
