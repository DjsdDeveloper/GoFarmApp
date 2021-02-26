using FFImageLoading.Svg.Forms;
using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class RegisterStepOne : ContentPage
    {
        bool IsPhone;
        int HeightView = App.screenHeight;
        int WidthView = App.screenWidth;
        public RegisterStepOne()
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

            GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });
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
                Text = "Paso 1: Datos personales",
                FontSize = 14,
                Margin = new Thickness(0, 20, 0, 0)
            }, 0, 3, 1, 2);

            var ImgProfile = new CircleImage
            {
                BorderColor = Color.FromHex("#E5E7E9"),
                BorderThickness = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFill,
                HeightRequest = 40,
                WidthRequest = 40,
                Margin = new Thickness(20, 40, 0, 0),
            };
            ImgProfile.SetBinding(CircleImage.SourceProperty, nameof(RegisterStepOneViewModel.ImagenMedia));

            TapGestureRecognizer tapPhoto = new TapGestureRecognizer();
            tapPhoto.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepOneViewModel.PhotoCommand));
            ImgProfile.GestureRecognizers.Add(tapPhoto);


            GridRegister.Children.Add(ImgProfile, 0, 1, 2, 3);

            var EntryFullName = new CustomEntry
            {
                FontSize = 12,
                Placeholder = "Nombre completo",
                Margin = new Thickness(10, 0, 10, 0)
            };

            var FrameEntryFullName = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 40, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryFullName
            };
            GridRegister.Children.Add(FrameEntryFullName, 1, 3, 2, 3);

            PickerCustom PickerDocument = new PickerCustom()
            {
                Margin = new Thickness(0),
                FontSize = 12,
                SelectedIndex = -1,
            };
            PickerDocument.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepOneViewModel.PickDoc));
            PickerDocument.SetBinding(PickerCustom.SelectedIndexProperty, nameof(RegisterStepOneViewModel.SeleccionVariacion1));

            var FramePickerDocument = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(20, 30, 0, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = PickerDocument
            };
            GridRegister.Children.Add(FramePickerDocument, 0, 1, 3, 4);

            var EntryDocumento = new CustomEntry
            {
                FontSize = 12,
                Placeholder = "Documento",
                Margin = new Thickness(10, 0, 10, 0),
                Keyboard = Keyboard.Numeric
            };

            var FrameDocumento = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryDocumento
            };
            GridRegister.Children.Add(FrameDocumento, 1, 3, 3, 4);

            SvgCachedImage IconFecha = new SvgCachedImage
            {
                Margin = new Thickness(20, 30, 0, 0),
                HeightRequest = 20,
                WidthRequest = 24,
                HorizontalOptions = LayoutOptions.Center,
                Source = "resource://TuFarmaApp.Img.Svg.calendario.svg",
                ReplaceStringMap = new Dictionary<string, string> { { "gray", "eeeeee" } },
            };
            GridRegister.Children.Add(IconFecha, 0, 1, 4, 5);

            var DataPickerFecha = new DatePicker
            {
                Margin = new Thickness(20, 30, 0, 0),
                HeightRequest = 25,
                WidthRequest = 30,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 4,
                TextColor = Color.Transparent,
                BackgroundColor = Color.Transparent
            };
            DataPickerFecha.SetBinding(DatePicker.DateProperty, nameof(RegisterStepOneViewModel.DataFecha));
            GridRegister.Children.Add(DataPickerFecha, 0, 1, 4, 5);

            var EntryFecha = new CustomEntry
            {
                FontSize = 12,
                Placeholder = "Fecha de nacimiento",
                Margin = new Thickness(10, 0, 10, 0),
                IsReadOnly = true
            };
            EntryFecha.SetBinding(CustomEntry.TextProperty, nameof(RegisterStepOneViewModel.EntryDataFecha));

            var FrameEntryFecha = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(10, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryFecha
            };
            GridRegister.Children.Add(FrameEntryFecha, 1, 3, 4, 5);

            var EntryTelefono = new CustomEntry()
            {
                FontSize = 12,
                Margin = new Thickness(10, 0, 10, 0),
                Placeholder = "Teléfono"
            };

            var FrameEntryTelefono = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(20, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryTelefono
            };
            GridRegister.Children.Add(FrameEntryTelefono, 0, 3, 5, 6);

            var EntryCorreo = new CustomEntry()
            {
                FontSize = 12,
                Margin = new Thickness(10, 0, 10, 0),
                Placeholder = "Correo electrónico"
            };

            var FrameEntryCorreo = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(20, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = EntryCorreo
            };
            GridRegister.Children.Add(FrameEntryCorreo, 0, 3, 6, 7);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Ir al paso 2"
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
            tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepOneViewModel.SiguienteCommand));
            frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            GridRegister.Children.Add(frameButtonRegister, 0, 3, 7, 8);

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
            tapButtonVolver.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepOneViewModel.VolverCommand));
            frameButtonVolver.GestureRecognizers.Add(tapButtonVolver);

            GridRegister.Children.Add(frameButtonVolver, 0, 3, 8, 9);

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