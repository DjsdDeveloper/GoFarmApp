using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class OlvidarPage : ContentPage
    {
        bool IsPhone;
        int HeightView = App.screenHeight;
        int WidthView = App.screenWidth;
        public OlvidarPage()
        {
            IsPhone = Device.Idiom == TargetIdiom.Phone;
            NavigationPage.SetHasNavigationBar(this, false);

            var GridFondo = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };
            GridFondo.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridFondo.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridFondo.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridFondo.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridFondo.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridFondo.Children.Add(new BoxView()
            {
                HeightRequest = (HeightView / 2),
                BackgroundColor = Color.FromHex("#0B3C93")
            }, 0, 3, 0, 1);

            //GridFondo.Children.Add(new BoxView()
            //{
            //    HeightRequest = (HeightView / 2),
            //    BackgroundColor = Color.FromHex("#eeeeee")
            //}, 0, 3, 1, 2);

            var GridMain = new Grid()
            {
                Padding = new Thickness(20, 15, 20, 30)
            };
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            GridMain.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //GridMain.Children.Add(new Image
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    //HeightRequest = 80,
            //    //WidthRequest = 80,
            //    HeightRequest = 100,
            //    WidthRequest = (WidthView / 3),
            //    Source = ImageSource.FromResource("TuFarmaApp.Img.GoApp.png")
            //}, 0, 0);

            #region Grid Register
            var GridOlvidar = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };

            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridOlvidar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridOlvidar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridOlvidar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridOlvidar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridOlvidar.SetBinding(Grid.IsVisibleProperty, nameof(LoginPageViewModel.IsVisibleRegister));

            GridOlvidar.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Recupera tu contraseña",
                FontSize = 18,
                Margin = new Thickness(0, 55, 0, 0)
            }, 0, 3, 0, 1);

            GridOlvidar.Children.Add(new Label
            {
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Text = "Introduce tu nombre de usuario y así recibiras en tu correo una nueva contraseña.",
                FontSize = 14,
                Margin = new Thickness(20, 20, 20, 0)
            }, 0, 3, 1, 2);

            SvgCachedImage IconUser = new SvgCachedImage
            {
                Margin = new Thickness(20, 40, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
                ReplaceStringMap = new Dictionary<string, string> { { "gray", "eeeeee" } },
            };
            GridOlvidar.Children.Add(IconUser, 0, 1, 2, 3);

            var EntryUsername = new CustomEntry
            {
                FontSize = 12,
                Placeholder = "Correo / Usuario",
                Margin = new Thickness(10, 0, 10, 0)
            };

            var FrameEntryUsername = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 40, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryUsername
            };
            GridOlvidar.Children.Add(FrameEntryUsername, 1, 3, 2, 3);

            var LabelButtonEnviar = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Enviar"
            };

            var GridButtonEnviar = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridButtonEnviar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridButtonEnviar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridButtonEnviar.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridButtonEnviar.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridButtonEnviar.Children.Add(LabelButtonEnviar, 1, 0);

            var frameButtonOlvidar = new Frame()
            {
                Margin = new Thickness(20, 30, 20, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#0000ff"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridButtonEnviar
            };

            //TapGestureRecognizer tapButtonSiguiente = new TapGestureRecognizer();
            //tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepTwoViewModel.SiguienteCommand));
            //frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            GridOlvidar.Children.Add(frameButtonOlvidar, 0, 3, 3, 4);

            var LabelButtonVolver = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Volver"
            };

            var GridVolverBoton = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridVolverBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridVolverBoton.Children.Add(LabelButtonVolver, 1, 0);

            var frameButtonVolver = new Frame()
            {
                Margin = new Thickness(20, 15, 20, 30),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#F80061"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridVolverBoton
            };

            TapGestureRecognizer tapButtonVolver = new TapGestureRecognizer();
            tapButtonVolver.SetBinding(TapGestureRecognizer.CommandProperty, nameof(OlvidarPageViewModel.VolverCommand));
            frameButtonVolver.GestureRecognizers.Add(tapButtonVolver);

            GridOlvidar.Children.Add(frameButtonVolver, 0, 3, 4, 5);
            #endregion

            GridMain.Children.Add(new Frame()
            {
                Padding = new Thickness(10),
                Margin = new Thickness(0, 50, 0, 0),
                BackgroundColor = Color.White,
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = GridOlvidar
            }, 0, 1);


            GridMain.Children.Add(new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 120,
                WidthRequest = 120,
                //HeightRequest = 100,
                //WidthRequest = (WidthView / 3),
                Source = ImageSource.FromResource("TuFarmaApp.Img.TopeMargarita.png")
            }, 0, 1, 0, 2);


            GridFondo.Children.Add(GridMain, 0, 3, 0, 2);

            var MainContainer = new Grid();

            MainContainer.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainContainer.Children.Add(new ScrollView
            {
                Padding = IsPhone ? 0 : new Thickness(100, 0),
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = GridFondo
            });

            Content = MainContainer;
        }
    }
}