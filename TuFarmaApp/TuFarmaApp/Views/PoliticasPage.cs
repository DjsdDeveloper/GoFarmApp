using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class PoliticasPage : ContentPage
    {
        bool IsPhone;
        int HeightView = App.screenHeight;
        int WidthView = App.screenWidth;

        public PoliticasPage()
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

            #region Grid Politicas
            var GridPoliticas = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };

            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridPoliticas.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridPoliticas.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridPoliticas.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridPoliticas.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridLogin.SetBinding(Grid.IsVisibleProperty, nameof(LoginPageViewModel.IsVisibleLogin));

            GridPoliticas.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Políticas de privacidad",
                FontSize = 18,
                Margin = new Thickness(0, 20, 0, 0)
            }, 0, 3, 0, 1);

            GridPoliticas.Children.Add(new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                //FontSize = 14,
                Margin = new Thickness(20, 40, 20, 0)
            }, 0, 3, 1, 2);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Volver"
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
                Margin = new Thickness(20, 30, 20, 3),
                Padding = new Thickness(0),
                BackgroundColor = Color.FromHex("#F80061"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.End,
                Content = GridButtonRegister
            };

            TapGestureRecognizer tapButtonSiguiente = new TapGestureRecognizer();
            tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(PoliticasPageViewModel.VolverCommand));
            frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            GridPoliticas.Children.Add(frameButtonRegister, 0, 3, 2, 3);

            //GridMain.Children.Add(GridLogin, 0, 3, 2, 3);
            #endregion

            GridMain.Children.Add(new Frame()
            {
                Padding = new Thickness(10),
                BackgroundColor = Color.White,
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = GridPoliticas
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