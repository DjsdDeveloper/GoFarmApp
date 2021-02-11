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
    public class LoginInit : ContentPage
    {
        bool IsPhone;
        int HeightView = App.screenHeight;
        int WidthView = App.screenWidth;

        public LoginInit()
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
                BackgroundColor = Color.FromHex("#04554C")
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

            GridMain.Children.Add(new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                //HeightRequest = 80,
                //WidthRequest = 80,
                HeightRequest = 100,
                WidthRequest = (WidthView / 3),
                Source = ImageSource.FromResource("TuFarmaApp.Img.GoApp.png")
            }, 0, 0);

            #region Grid Login
            var GridLogin = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };

            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridLogin.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridLogin.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridLogin.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridLogin.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridLogin.SetBinding(Grid.IsVisibleProperty, nameof(LoginPageViewModel.IsVisibleLogin));

            GridLogin.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Bienvenido",
                FontSize = 18,
                Margin = new Thickness(0, 20, 0, 0)
            }, 0, 3, 0, 1);

            SvgCachedImage IconUser = new SvgCachedImage
            {
                Margin = new Thickness(20, 40, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
                ReplaceStringMap = new Dictionary<string, string> { { "gray", "eeeeee" } },
            };
            GridLogin.Children.Add(IconUser, 0, 1, 1, 2);

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
            GridLogin.Children.Add(FrameEntryUsername, 1, 3, 1, 2);

            SvgCachedImage IconPass = new SvgCachedImage
            {
                Margin = new Thickness(20, 30, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.Password.svg"
            };
            GridLogin.Children.Add(IconPass, 0, 1, 2, 3);

            var EntryPass = new CustomEntry
            {
                FontSize = 12,
                Placeholder = "Contraseña",
                Margin = new Thickness(10, 0, 10, 0),
                IsPassword = true
            };

            var FrameEntryPass = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryPass
            };
            GridLogin.Children.Add(FrameEntryPass, 1, 3, 2, 3);

            var LabelButtonLogin = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Iniciar sesión"
            };

            var GridTwoBoton = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridTwoBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridTwoBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridTwoBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridTwoBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridTwoBoton.Children.Add(LabelButtonLogin, 1, 0);

            var frameButtonLogin = new Frame()
            {
                Margin = new Thickness(20, 30, 20, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#4f29B8"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridTwoBoton
            };

            //TapGestureRecognizer tapButtonLogin = new TapGestureRecognizer();
            //tapButtonLogin.SetBinding(TapGestureRecognizer.CommandProperty, nameof(AddProfileViewModel.SavePhotoCommand));
            //frameButtonLogin.GestureRecognizers.Add(tapButtonLogin);

            GridLogin.Children.Add(frameButtonLogin, 0, 3, 3, 4);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Registrar"
            };

            var GridRegBoton = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridRegBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridRegBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridRegBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridRegBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridRegBoton.Children.Add(LabelButtonRegister, 1, 0);

            var frameButtonRegister = new Frame()
            {
                Margin = new Thickness(20, 15, 20, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#F80061"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridRegBoton
            };

            TapGestureRecognizer tapButtonRegister = new TapGestureRecognizer();
            tapButtonRegister.SetBinding(TapGestureRecognizer.CommandProperty, nameof(LoginInitViewModel.RegisterCommand));
            frameButtonRegister.GestureRecognizers.Add(tapButtonRegister);

            GridLogin.Children.Add(frameButtonRegister, 0, 3, 4, 5);

            var LabelButtonInvitado = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Invitado"
            };

            var GridInvBoton = new Grid()
            {
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Center
            };

            GridInvBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridInvBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridInvBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            GridInvBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridInvBoton.Children.Add(LabelButtonInvitado, 1, 0);

            var frameButtonInvitado = new Frame()
            {
                Margin = new Thickness(20, 15, 20, 0),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#Ff9400"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridInvBoton
            };

            //TapGestureRecognizer tapButtonLogin = new TapGestureRecognizer();
            //tapButtonLogin.SetBinding(TapGestureRecognizer.CommandProperty, nameof(AddProfileViewModel.SavePhotoCommand));
            //frameButtonLogin.GestureRecognizers.Add(tapButtonLogin);

            GridLogin.Children.Add(frameButtonInvitado, 0, 3, 5, 6);

            Label LabelOlvido = new Label
            {
                Margin = new Thickness(0, 15, 0, 15),
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "¿Olvidaste tu contraseña?",
            };
            //TapGestureRecognizer tapOlvidaste = new TapGestureRecognizer();
            //tapOlvidaste.SetBinding(TapGestureRecognizer.CommandProperty, nameof(LoginPageViewModel.CommandOlvido));
            //LabelOlvido.GestureRecognizers.Add(tapOlvidaste);

            GridLogin.Children.Add(LabelOlvido, 0, 3, 6, 7);

            var GridPoliticaTerminos = new Grid()
            {
                BackgroundColor = Color.Transparent,
                Margin = new Thickness(0, 10, 0, 20),
            };

            GridPoliticaTerminos.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridPoliticaTerminos.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridPoliticaTerminos.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });

            GridPoliticaTerminos.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            Label Politicas = new Label()
            {
                Text = "Políticas de privacidad",
                TextColor = Color.FromHex("#F80061"),
                HorizontalOptions = LayoutOptions.End,
                FontSize = 10
            };
            TapGestureRecognizer tapPolitica = new TapGestureRecognizer();
            tapPolitica.SetBinding(TapGestureRecognizer.CommandProperty, nameof(LoginInitViewModel.CommandPoliticas));
            Politicas.GestureRecognizers.Add(tapPolitica);

            GridPoliticaTerminos.Children.Add(Politicas, 0, 0);

            GridPoliticaTerminos.Children.Add(new Label()
            {
                Text = " | ",
                TextColor = Color.FromHex("#F80061"),
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 12
            }, 1, 0);

            Label Terminos = new Label()
            {
                Text = "Términos y condiciones",
                TextColor = Color.FromHex("#F80061"),
                HorizontalOptions = LayoutOptions.Start,
                FontSize = 10
            };
            TapGestureRecognizer tapTerminos = new TapGestureRecognizer();
            tapTerminos.SetBinding(TapGestureRecognizer.CommandProperty, nameof(LoginInitViewModel.CommandTerminos));
            Terminos.GestureRecognizers.Add(tapTerminos);

            GridPoliticaTerminos.Children.Add(Terminos, 2, 0);

            GridLogin.Children.Add(GridPoliticaTerminos, 0, 3, 7, 8);

            //GridMain.Children.Add(GridLogin, 0, 3, 2, 3);
            #endregion

            GridMain.Children.Add(new Frame()
            {
                Padding = new Thickness(10),
                BackgroundColor = Color.White,
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = GridLogin
            }, 0, 1);





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
            //SizeChanged += LoginPage_SizeChanged;
        }

        //void LoginPage_SizeChanged(object sender, EventArgs e)
        //{
        //    if (Width > Height)
        //    {
        //        // Landscape
        //        if (IsPhone)
        //        {
        //            //Separator.WidthRequest = 200;

        //            frameLogin.WidthRequest = 200;
        //            frameLate.WidthRequest = 200;
        //            frameRegister.WidthRequest = 200;

        //            frameLogin.HorizontalOptions = LayoutOptions.Center;
        //            frameLate.HorizontalOptions = LayoutOptions.Center;
        //            frameRegister.HorizontalOptions = LayoutOptions.Center;

        //            //Separator.HorizontalOptions = LayoutOptions.Center;
        //        }
        //        else
        //        {
        //            //Separator.WidthRequest = 400;

        //            frameLogin.WidthRequest = 400;
        //            frameLate.WidthRequest = 400;
        //            frameRegister.WidthRequest = 400;

        //            frameLogin.HorizontalOptions = LayoutOptions.Center;
        //            frameLate.HorizontalOptions = LayoutOptions.Center;
        //            frameRegister.HorizontalOptions = LayoutOptions.Center;

        //            //Separator.HorizontalOptions = LayoutOptions.Center;
        //        }
        //    }
        //    else
        //    {
        //        // Portrait
        //        if (IsPhone)
        //        {
        //            //Separator.HorizontalOptions = LayoutOptions.Fill;

        //            frameLogin.HorizontalOptions = LayoutOptions.Fill;
        //            frameLate.HorizontalOptions = LayoutOptions.Fill;
        //            frameRegister.HorizontalOptions = LayoutOptions.Fill;
        //        }
        //        else
        //        {
        //            //Separator.HorizontalOptions = LayoutOptions.Fill;

        //            frameLogin.HorizontalOptions = LayoutOptions.Fill;
        //            frameLate.HorizontalOptions = LayoutOptions.Fill;
        //            frameRegister.HorizontalOptions = LayoutOptions.Fill;
        //        }
        //    }
        //}
    }
}