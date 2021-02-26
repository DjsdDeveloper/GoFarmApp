using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using ImageCircle.Forms.Plugin.Abstractions;
using Prism.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.Models;
using TuFarmaApp.Styles;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class MenuLogin : MasterDetailPage
    {

        public MenuLogin()
        {
            var size = Device.GetNamedSize(NamedSize.Medium, typeof(Label));

            if (Device.Idiom == TargetIdiom.Phone)
            {
                size = Device.GetNamedSize(NamedSize.Small, typeof(Label));
            }

            var ListViewMenu = new ListView
            {
                //ItemTemplate = new DataTemplate(() => new Celda(this.BindingContext)),
                ItemTemplate = new DataTemplate(() =>
                {
                    SvgCachedImage ButtonIcon = new SvgCachedImage
                    {
                        HorizontalOptions = LayoutOptions.Start,
                        HeightRequest = 18,
                        WidthRequest = 18,
                        //Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
                    };
                    ButtonIcon.SetBinding(SvgCachedImage.SourceProperty,
                        nameof(MenuModel.Icon),
                        stringFormat: "resource://{0:F2}");

                    Label label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = size,
                        //Text = "Texto"
                    };
                    label.SetBinding(Label.TextProperty, nameof(MenuModel.Text));

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Margin = new Thickness(20, 10),
                            Spacing = 10,
                            Children =
                            {
                                ButtonIcon,
                                label
                            }
                        }
                    };
                }),
                HasUnevenRows = true,
                SeparatorVisibility = SeparatorVisibility.Default,
                SeparatorColor = Color.Black,
                VerticalScrollBarVisibility = ScrollBarVisibility.Never,
                ItemsSource = new List<MenuModel>
                {
                    new MenuModel
                    {
                        Text = "Mis transacciones",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.transacciones.svg",
                        //PageName = nameof(Carrito)
                    },
                    new MenuModel
                    {
                        Text = "Historial de busquedas",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.history.svg",
                        //PageName = nameof(Addres)
                    },
                    new MenuModel
                    {
                        Text = "Top tiendas",
                        Icon =  "TuFarmaApp.Img.Svg.conversation.svg",
                        //PageName = nameof(NewShop)
                    },
                    new MenuModel
                    {
                        Text = "Sitios visitados",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.viewrecent.svg",
                        //PageName = $"{nameof(RouteBuy1)}"
                    },
                    new MenuModel
                    {
                        Text = "Favoritos",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.favorito.svg",
                        //PageName = $"{nameof(RouteBuy1)}"
                    },
                    new MenuModel
                    {
                        Text = "Configuración",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.setting.svg",
                        //PageName = $"{nameof(MySalesTabPage)}"
                    },
                    new MenuModel
                    {
                        Text = "Ayuda",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.ayuda.svg",
                        //PageName = nameof(MisCompras)
                    },
                    //new MenuModel
                    //{
                    //    Text = "Información general",
                    //    Icon =  "TuFarmaApp.Img.Svg.conversation.svg",
                    //    //PageName = nameof(InfoGeneral)
                    //},
                    new MenuModel
                    {
                        Text = "Cerrar sesión",
                        Icon =  "TuFarmaApp.Img.Svg.SvgMenu.logout.svg",
                        PageName = nameof(LoginInit)
                    }
                }
            };

            var imgProfile = new CircleImage
            {
                BorderColor = Color.FromHex("#E5E7E9"),
                BorderThickness = 1,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFill,
                HeightRequest = 100,
                WidthRequest = 100,
                Source = ImageSource.FromResource("TuFarmaApp.Img.no-picture-user.jpg"),
                Margin = new Thickness(0, 20, 0, 0),
            };

            var LabelUserName = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 16,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0, 0, 0, 20),
                Text = "Darwin José Sansonetti Díaz"
            };

            //SvgCachedImage FiltrarIcon = new SvgCachedImage
            //{
            //    HorizontalOptions = LayoutOptions.Start,
            //    HeightRequest = 18,
            //    WidthRequest = 18,
            //    Source = "resource://TuFarmaApp.Img.Svg.SvgMenu.filter.svg",
            //};

            //var filtrar = new Label
            //{
            //    Margin = new Thickness(0, 0, 0, 0),
            //    Text = "Filtrar busqueda",
            //    VerticalTextAlignment = TextAlignment.Center,
            //    FontSize = size
            //};

            SvgCachedImage InformationIcon = new SvgCachedImage
            {
                HorizontalOptions = LayoutOptions.Start,
                HeightRequest = 18,
                WidthRequest = 18,
                Source = "resource://TuFarmaApp.Img.Svg.SvgMenu.info.svg",
            };

            var Information = new Label
            {
                Margin = new Thickness(0, 0, 0, 0),
                Text = "Información personal",
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = size
            };

            #region Grid Register
            //var GridRegister = new Grid()
            //{
            //    RowSpacing = 0,
            //    BackgroundColor = Color.FromHex("#eeeeee")
            //};

            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            //GridRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            //GridRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            ////GridRegister.SetBinding(Grid.IsVisibleProperty, nameof(LoginPageViewModel.IsVisibleRegister));

            ////GridRegister.Children.Add(new Label
            ////{
            ////    HorizontalOptions = LayoutOptions.Center,
            ////    VerticalOptions = LayoutOptions.Center,
            ////    Text = "Registro",
            ////    FontSize = 18,
            ////    Margin = new Thickness(0, 20, 0, 0)
            ////}, 0, 3, 0, 1);

            ////GridRegister.Children.Add(new Label
            ////{
            ////    HorizontalOptions = LayoutOptions.Center,
            ////    VerticalOptions = LayoutOptions.Center,
            ////    Text = "Paso 2: Ubicación",
            ////    FontSize = 14,
            ////    Margin = new Thickness(0, 20, 0, 0)
            ////}, 0, 3, 1, 2);

            //var PickerEstado = new CustomEntry()
            //{
            //    FontSize = 12,
            //    Margin = new Thickness(0),
            //    Placeholder = "Estado"
            //};
            ////PickerEstado.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickEstado));

            //var FramePickerEstado = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 20, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2.2),
            //    Content = PickerEstado
            //};
            //GridRegister.Children.Add(FramePickerEstado, 0, 3, 0, 1);

            //var PickerMunicipio = new CustomEntry()
            //{
            //    FontSize = 12,
            //    Margin = new Thickness(0),
            //    Placeholder = "Municipio"
            //};
            ////PickerMunicipio.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickMunicipio));

            //var FramePickerMunicipio = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 30, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2.2),
            //    Content = PickerMunicipio
            //};

            //GridRegister.Children.Add(FramePickerMunicipio, 0, 3, 1, 2);

            ////var EntryDireccion = new CustomEditor()
            ////{
            ////    FontSize = 12,
            ////    HeightRequest = 72,
            ////    Margin = new Thickness(10, 0, 10, 0),
            ////    Placeholder = "Dirección"
            ////};

            ////var FrameEntryDireccion = new Frame()
            ////{
            ////    Padding = new Thickness(0),
            ////    BackgroundColor = Color.White,
            ////    Margin = new Thickness(20, 30, 20, 0),
            ////    BorderColor = Color.Transparent,
            ////    IsClippedToBounds = true,
            ////    CornerRadius = 10,
            ////    Content = EntryDireccion
            ////};
            ////GridRegister.Children.Add(FrameEntryDireccion, 0, 3, 4, 5);

            //var CostoMin = new CustomEntry()
            //{
            //    FontSize = 12,
            //    Margin = new Thickness(0),
            //    Placeholder = "Costo Min"
            //};
            ////CostoMin.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickMunicipio));

            //var FrameCostoMin = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 30, 0, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2),
            //    Content = CostoMin
            //};

            //var CostoMax = new CustomEntry()
            //{
            //    FontSize = 12,
            //    Margin = new Thickness(0),
            //    Placeholder = "Costo Max"
            //};
            ////CostoMax.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickMunicipio));

            //var FrameCostoMax = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(0, 30, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2),
            //    Content = CostoMax
            //};

            //GridRegister.Children.Add(
            //    new StackLayout()
            //    {
            //        Orientation = StackOrientation.Horizontal,
            //        Children =
            //        {
            //            FrameCostoMin,
            //            new Label()
            //            {
            //                FontSize = 14,
            //                HorizontalTextAlignment = TextAlignment.Start,
            //                VerticalTextAlignment = TextAlignment.Center,
            //                Margin = new Thickness(5, 30, 5, 0),
            //                Text = " - "
            //            },
            //            FrameCostoMax
            //        }
            //    }
            //, 0, 3, 2, 3);

            //var LabelButtonRegister = new Label()
            //{
            //    FontSize = 14,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    Margin = new Thickness(0),
            //    TextColor = Color.White,
            //    Text = "Filtrar"
            //};

            //var GridButtonRegister = new Grid()
            //{
            //    BackgroundColor = Color.Transparent,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            //GridButtonRegister.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridButtonRegister.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //GridButtonRegister.Children.Add(LabelButtonRegister, 1, 0);

            //var frameButtonRegister = new Frame()
            //{
            //    Margin = new Thickness(20, 15, 20, 10),
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.FromHex("#4f29B8"),
            //    BorderColor = Color.Transparent,
            //    HeightRequest = 40,
            //    VerticalOptions = LayoutOptions.Center,
            //    Content = GridButtonRegister
            //};

            ////TapGestureRecognizer tapButtonSiguiente = new TapGestureRecognizer();
            ////tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepTwoViewModel.SiguienteCommand));
            ////frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            //GridRegister.Children.Add(frameButtonRegister, 0, 3, 3, 4);

            ////GridRegister.Children.Add(new BoxView
            ////{
            ////    HeightRequest = 4,
            ////    //BackgroundColor = Color.FromHex("#f2f1f1"),
            ////    BackgroundColor = Color.Black,
            ////    VerticalOptions = LayoutOptions.Start
            ////}, 0, 3, 2, 3);


            ////var LabelButtonVolver = new Label()
            ////{
            ////    FontSize = 14,
            ////    HorizontalTextAlignment = TextAlignment.Center,
            ////    VerticalTextAlignment = TextAlignment.Center,
            ////    Margin = new Thickness(0),
            ////    TextColor = Color.White,
            ////    Text = "Volver"
            ////};

            ////var GridVolverBoton = new Grid()
            ////{
            ////    BackgroundColor = Color.Transparent,
            ////    VerticalOptions = LayoutOptions.Center
            ////};

            ////GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            ////GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            ////GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            ////GridVolverBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            ////GridVolverBoton.Children.Add(LabelButtonVolver, 1, 0);

            ////var frameButtonVolver = new Frame()
            ////{
            ////    Margin = new Thickness(20, 15, 20, 30),
            ////    Padding = new Thickness(0),
            ////    BackgroundColor = Color.FromHex("#F80061"),
            ////    BorderColor = Color.Transparent,
            ////    HeightRequest = 40,
            ////    VerticalOptions = LayoutOptions.Center,
            ////    Content = GridVolverBoton
            ////};

            ////TapGestureRecognizer tapButtonVolver = new TapGestureRecognizer();
            ////tapButtonVolver.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepTwoViewModel.VolverCommand));
            ////frameButtonVolver.GestureRecognizers.Add(tapButtonVolver);

            ////GridRegister.Children.Add(frameButtonVolver, 0, 3, 6, 7);

            ////GridMain.Children.Add(GridLogin, 0, 3, 2, 3);
            ////GridMain.Children.Add(GridRegister, 0, 3, 2, 3);
            #endregion

            #region Grid Information
            var GridInformation = new Grid()
            {
                RowSpacing = 0,
                BackgroundColor = Color.FromHex("#eeeeee")
            };

            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            GridInformation.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            GridInformation.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            GridInformation.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            GridInformation.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            CachedImage InfoPerIcon = new CachedImage
            {
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "resource://TuFarmaApp.Img.GoMenu.png",
                Margin = new Thickness(30, 20, 0, 0)
            };
            GridInformation.Children.Add(InfoPerIcon, 0, 1, 0, 1);

            var LabelPersonal = new Label()
            {
                FontSize = size,
                Text = "Datos Personales",
                Margin = new Thickness(0, 20, 20, 0)
            };
            //PickerEstado.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickEstado));

            //var FrameLabelPersonal = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 20, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2.2),
            //    Content = LabelPersonal
            //};
            GridInformation.Children.Add(LabelPersonal, 1, 3, 0, 1);

            CachedImage UbicacionIcon = new CachedImage
            {
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "resource://TuFarmaApp.Img.GoMenu.png",
                Margin = new Thickness(30, 20, 0, 0)
            };
            GridInformation.Children.Add(UbicacionIcon, 0, 1, 1, 2);

            var LabelUbicacion = new Label()
            {
                FontSize = size,
                Margin = new Thickness(0, 20, 20, 0),
                Text = "Ubicación"
            };
            //PickerMunicipio.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickMunicipio));

            //var FramePickerMunicipio = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 30, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    WidthRequest = (App.screenWidth / 2.2),
            //    Content = PickerMunicipio
            //};

            GridInformation.Children.Add(LabelUbicacion, 1, 3, 1, 2);

            CachedImage SesionIcon = new CachedImage
            {
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "resource://TuFarmaApp.Img.GoMenu.png",
                Margin = new Thickness(30, 20, 0, 20)
            };
            GridInformation.Children.Add(SesionIcon, 0, 1, 2, 3);

            var LabelSesion = new Label()
            {
                FontSize = size,
                Margin = new Thickness(0, 20, 0, 20),
                Text = "Datos de la sesión"
            };

            GridInformation.Children.Add(LabelSesion, 1, 3, 2, 3);

            //GridInformation.Children.Add(frameButtonRegister, 0, 3, 2, 3);
            #endregion

            //StackLayout TitleFilter = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    //VerticalOptions = LayoutOptions.End,
            //    Margin = new Thickness(20, 5),
            //    Spacing = 10,
            //    Children =
            //    {
            //        FiltrarIcon,
            //        filtrar
            //    }
            //};
            //TapGestureRecognizer tapTitleFilter = new TapGestureRecognizer();
            //tapTitleFilter.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuLoginViewModel.ActivarFilterCommand));
            //TitleFilter.GestureRecognizers.Add(tapTitleFilter);

            //BoxView BoxSuperior = new BoxView
            //{
            //    HeightRequest = 0.5,
            //    //BackgroundColor = Color.FromHex("#f2f1f1"),
            //    BackgroundColor = Color.Black,
            //    VerticalOptions = LayoutOptions.Start
            //};
            //BoxSuperior.SetBinding(BoxView.IsVisibleProperty, nameof(MenuLoginViewModel.IsVisibleFrameFilter));

            //Frame FrameFilter = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    BorderColor = Color.Black,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    Content = GridRegister
            //};
            //FrameFilter.SetBinding(Frame.IsVisibleProperty, nameof(MenuLoginViewModel.IsVisibleFrameFilter));


            //BoxView BoxInferior = new BoxView
            //{
            //    HeightRequest = 0.5,
            //    //BackgroundColor = Color.FromHex("#f2f1f1"),
            //    BackgroundColor = Color.Black,
            //    VerticalOptions = LayoutOptions.Start
            //};

            StackLayout TitleInformacion = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                //VerticalOptions = LayoutOptions.End,
                Margin = new Thickness(20, 5),
                Spacing = 10,
                Children =
                {
                    InformationIcon,
                    Information
                }
            };
            TapGestureRecognizer tapTitleInformacion = new TapGestureRecognizer();
            tapTitleInformacion.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MenuLoginViewModel.ActivarInformationCommand));
            TitleInformacion.GestureRecognizers.Add(tapTitleInformacion);

            BoxView BoxInferiorInf = new BoxView
            {
                HeightRequest = 0.5,
                //BackgroundColor = Color.FromHex("#f2f1f1"),
                BackgroundColor = Color.Black,
                VerticalOptions = LayoutOptions.Start
            };

            BoxView BoxInfSuperior = new BoxView
            {
                HeightRequest = 0.5,
                //BackgroundColor = Color.FromHex("#f2f1f1"),
                BackgroundColor = Color.Black,
                VerticalOptions = LayoutOptions.Start
            };
            BoxInfSuperior.SetBinding(BoxView.IsVisibleProperty, nameof(MenuLoginViewModel.IsVisibleFrameInformation));

            Frame FrameInformation = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                BorderColor = Color.Black,
                IsClippedToBounds = true,
                CornerRadius = 10,
                Content = GridInformation
            };
            FrameInformation.SetBinding(Frame.IsVisibleProperty, nameof(MenuLoginViewModel.IsVisibleFrameInformation));

            ListViewMenu.Header = new StackLayout
            {
                Children =
                {
                    imgProfile,
                    LabelUserName,
                    //TitleFilter,
                    //BoxSuperior,                    
                    //FrameFilter,
                    //BoxInferior,
                    TitleInformacion,
                    BoxInfSuperior,
                    FrameInformation,
                    BoxInferiorInf
                }
            };

            var ListViewTapCommand = new EventToCommandBehavior
            {
                EventName = nameof(ListView.ItemTapped),
                EventArgsParameterPath = nameof(ItemTappedEventArgs.Item)
            };
            ListViewTapCommand.SetBinding(EventToCommandBehavior.CommandProperty, nameof(MenuLoginViewModel.CommandMenuTap));
            ListViewMenu.Behaviors.Add(ListViewTapCommand);

            var MainContainer = new Grid();
            MainContainer.Children.Add(ListViewMenu, 0, 0);

            var _Master = new ContentPage
            {
                Title = "Menu",
                Padding = Device.RuntimePlatform == Device.iOS ? new Thickness(0, 20, 0, 0) : new Thickness(0),
                Content = MainContainer
            };
            Master = _Master;
        }
    }
}