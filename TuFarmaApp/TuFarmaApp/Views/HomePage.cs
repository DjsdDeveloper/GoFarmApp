using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            #region NAVIGATION PAGE
            var SearchBar = new CustomEntry
            {
                Margin = new Thickness(10, 0, 0, 0),
                FontSize = 12,
                Placeholder = "Buscar medicamento",
                HeightRequest = 35,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            //SearchBar.SetBinding(CustomEntry.TextProperty, nameof(MarketMainPageD2ViewModel.SearchQuery));

            var FrameSearchBar = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 0, 0, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = SearchBar
            };

            var Iconpar = new Image
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 22,
                WidthRequest = 22,
                Margin = new Thickness(0),
                Source = ImageSource.FromResource("TuFarmaApp.Img.lupa.png")
            };
            //TapGestureRecognizer tap1 = new TapGestureRecognizer();
            //tap1.SetBinding(TapGestureRecognizer.CommandProperty, nameof(Step3PageViewModel.ExitCommand));
            //Iconpar.GestureRecognizers.Add(tap1);

            var grid = new Grid() { };

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(3, GridUnitType.Auto) });//Entry89

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(FrameSearchBar, 0, 0);
            grid.Children.Add(Iconpar, 1, 0); //Utilizado para colocar un icono al lado de la barra de navegacion

            NavigationPage.SetTitleView(this, grid);

            //NavigationPage.SetTitleView(this, FrameSearchBar);
            #endregion

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}