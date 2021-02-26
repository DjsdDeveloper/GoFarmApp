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
    public class RegisterStepThree : ContentPage
    {
        bool IsPhone;
        int HeightView = App.screenHeight;
        int WidthView = App.screenWidth;
        public RegisterStepThree()
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
            var GridRegister = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };

            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridRegister.SetBinding(Grid.IsVisibleProperty, nameof(LoginPageViewModel.IsVisibleRegister));

            GridRegister.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Registro",
                FontSize = 18,
                Margin = new Thickness(0, 55, 0, 0)
            }, 0, 3, 0, 1);

            GridRegister.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Paso 3: Datos de la sesión",
                FontSize = 14,
                Margin = new Thickness(0, 20, 0, 0)
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
            GridRegister.Children.Add(IconUser, 0, 1, 2, 3);

            var EntryUsuario = new CustomEntry()
            {
                FontSize = 12,
                Margin = new Thickness(10, 0, 10, 0),
                Placeholder = "Usuario"
            };

            var FrameEntryUsuario = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 40, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryUsuario
            };
            GridRegister.Children.Add(FrameEntryUsuario, 1, 3, 2, 3);

            SvgCachedImage IconPass = new SvgCachedImage
            {
                Margin = new Thickness(20, 30, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.Password.svg"
            };
            GridRegister.Children.Add(IconPass, 0, 1, 3, 4);

            var EntryContraseña = new CustomEntry()
            {
                FontSize = 12,
                Margin = new Thickness(10, 0, 10, 0),
                Placeholder = "Contraseña",
                IsPassword = true
            };

            var FrameEntryContraseña = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryContraseña
            };
            GridRegister.Children.Add(FrameEntryContraseña, 1, 3, 3, 4);

            SvgCachedImage IconPassConf = new SvgCachedImage
            {
                Margin = new Thickness(20, 30, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.Password.svg"
            };
            GridRegister.Children.Add(IconPassConf, 0, 1, 4, 5);

            var EntryConfirmarContraseña = new CustomEntry()
            {
                FontSize = 12,
                Margin = new Thickness(10, 0, 10, 0),
                Placeholder = "Confirmar contraseña",
                IsPassword = true
            };

            var FrameEntryConfirmarContraseña = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryConfirmarContraseña
            };
            GridRegister.Children.Add(FrameEntryConfirmarContraseña, 1, 3, 4, 5);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Finalizar"
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
                Margin = new Thickness(20, 30, 20, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#0000ff"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridButtonRegister
            };

            TapGestureRecognizer tapButtonSiguiente = new TapGestureRecognizer();
            tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepThreeViewModel.SiguienteCommand));
            frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            GridRegister.Children.Add(frameButtonRegister, 0, 3, 5, 6);

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
            tapButtonVolver.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepThreeViewModel.VolverCommand));
            frameButtonVolver.GestureRecognizers.Add(tapButtonVolver);

            GridRegister.Children.Add(frameButtonVolver, 0, 3, 6, 7);

            //GridMain.Children.Add(GridLogin, 0, 3, 2, 3);
            //GridMain.Children.Add(GridRegister, 0, 3, 2, 3);
            #endregion

            GridMain.Children.Add(new Frame()
            {
                Padding = new Thickness(10),
                Margin = new Thickness(0, 50, 0, 0),
                BackgroundColor = Color.White,
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = GridRegister
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