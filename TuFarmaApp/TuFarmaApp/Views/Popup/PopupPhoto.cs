using FFImageLoading.Forms;
using ImageCircle.Forms.Plugin.Abstractions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.ViewModels.Popup;
using Xamarin.Forms;

namespace TuFarmaApp.Views.Popup
{
    public class PopupPhoto :  PopupPage
    {
        public PopupPhoto()
        {
            var go = new Label()
            {
                Text = "Aceptar",
                FontSize = 14,
                //FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#81b71b"),
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center
            };
            //TapGestureRecognizer tap2 = new TapGestureRecognizer();
            //tap2.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PopupInitViewModel.GoCommand));
            //go.GestureRecognizers.Add(tap2);

            //var cancel = new Label()
            //{
            //    Text = "Cancelar",
            //    FontSize = 14,
            //    //FontAttributes = FontAttributes.Bold,
            //    TextColor = Color.FromHex("#81b71b"),
            //    HorizontalTextAlignment = TextAlignment.End,
            //    VerticalTextAlignment = TextAlignment.Center
            //};
            //TapGestureRecognizer tap1 = new TapGestureRecognizer();
            //tap1.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PopupPhotoViewModel.CancelCommand));
            //cancel.GestureRecognizers.Add(tap1);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Cancelar"
            };

            var GridButtonRegister = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridButtonRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridButtonRegister.Children.Add(LabelButtonRegister, 1, 0);

            var frameButtonRegister = new Frame()
            {
                Margin = new Thickness(0, 20, 0, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#4f29B8"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridButtonRegister
            };
            TapGestureRecognizer tap1 = new TapGestureRecognizer();
            tap1.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PopupPhotoViewModel.CancelCommand));
            frameButtonRegister.GestureRecognizers.Add(tap1);

            var GridMain = new Grid()
            {
                Margin = new Thickness(30, 0, 30, 0)
            };

            GridMain.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridMain.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridMain.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //var imgProfile = new CircleImage
            //{
            //    BorderColor = Color.FromHex("#E5E7E9"),
            //    BorderThickness = 1,
            //    HorizontalOptions = LayoutOptions.Center,
            //    Aspect = Aspect.AspectFill,
            //    HeightRequest = 80,
            //    WidthRequest = 80,
            //    Source = ImageSource.FromResource("TuFarmaApp.Img.no-picture-user.jpg"),
            //    //Margin = new Thickness(0, 20, 0, 0),
            //};
            //GridMain.Children.Add(imgProfile, 0, 3, 0, 1);

            var imgTomar = new CachedImage
            {
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 60,
                WidthRequest = 60,
                Source = "resource://TuFarmaApp.Img.Camara.png"
            };

            var LabelTomar = new Label()
            {
                FontSize = 12,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Start,
                TextColor = Color.Black,
                Text = "Tomar foto"
            };

            var gridTomar = new Grid
            {
                Margin = new Thickness(0, 0, 50, 0),
                Padding = new Thickness(0),
                //BackgroundColor = Color.FromHex("#eeeeee"),
            };

            gridTomar.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            gridTomar.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            gridTomar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridTomar.Children.Add(imgTomar, 0, 0);
            gridTomar.Children.Add(LabelTomar, 0, 1);

            TapGestureRecognizer tapTomar = new TapGestureRecognizer();
            tapTomar.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PopupPhotoViewModel.TomarCommand));
            gridTomar.GestureRecognizers.Add(tapTomar);


            var imgSubir = new CachedImage
            {
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 60,
                WidthRequest = 60,
                Source = "resource://TuFarmaApp.Img.Galeria.png"
            };

            var LabelSubir = new Label()
            {
                FontSize = 12,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Start,
                TextColor = Color.Black,
                Text = "Galería"
            };

            var gridSubir = new Grid
            {
                Padding = new Thickness(0),
                //BackgroundColor = Color.FromHex("#eeeeee"),
            };

            gridSubir.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            gridSubir.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });
            gridSubir.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            gridSubir.Children.Add(imgSubir, 0, 0);
            gridSubir.Children.Add(LabelSubir, 0, 1);

            TapGestureRecognizer tapGaleria = new TapGestureRecognizer();
            tapGaleria.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PopupPhotoViewModel.GaleriaCommand));
            gridSubir.GestureRecognizers.Add(tapGaleria);

            GridMain.Children.Add(new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    gridTomar,
                    gridSubir
                }
            }, 0, 3, 0, 1);

            GridMain.Children.Add(new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(20, 10, 20, 0),
                Spacing = 15,
                Children =
                {
                    //go,
                    frameButtonRegister
                }
            }, 0, 3, 4, 5);

            var frame = new Frame()
            {
                Margin = new Thickness(30),
                //Padding = new Thickness(10),
                BackgroundColor = Color.White,
                //HeightRequest = 160,
                Content = GridMain
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    frame
                }
            };
        }
    }
}