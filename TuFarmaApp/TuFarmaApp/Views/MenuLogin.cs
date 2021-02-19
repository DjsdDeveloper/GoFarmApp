using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.Styles;
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
                        Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
                    };
                    //ButtonIcon.SetBinding(SvgCachedImage.SourceProperty,
                    //    nameof(MenuModel.Icon),
                    //    stringFormat: "resource://{0:F2}");

                    Label label = new Label
                    {
                        VerticalTextAlignment = TextAlignment.Center,
                        FontSize = size,
                        Text = "Texto"
                    };
                    //label.SetBinding(Label.TextProperty, nameof(MenuModel.Text));

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
                ItemsSource = new List<string>
                {
                    "Filtrar",
                    "Texto2",
                    "Texto3"
                }
            };

            var imgProfile = new CircleImage
            {
                BorderColor = Color.FromHex("#E5E7E9"),
                BorderThickness = 1,
                HorizontalOptions = LayoutOptions.Center,
                Aspect = Aspect.AspectFill,
                HeightRequest = 80,
                WidthRequest = 80,
                Source = ImageSource.FromResource("TuFarmaApp.Img.no-picture-user.jpg"),
                Margin = new Thickness(0, 20, 0, 0),
            };

            var LabelUserName = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0, 0, 0, 20),
                Text = "Darwin José Sansonetti Díaz"
            };

            SvgCachedImage FiltrarIcon = new SvgCachedImage
            {
                HorizontalOptions = LayoutOptions.Start,
                HeightRequest = 18,
                WidthRequest = 18,
                Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
            };

            var filtrar = new Label
            {
                Margin = new Thickness(0, 0, 0, 0),
                Text = "Filtrar",
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = size
            };

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

            //GridRegister.Children.Add(new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Registro",
            //    FontSize = 18,
            //    Margin = new Thickness(0, 20, 0, 0)
            //}, 0, 3, 0, 1);

            //GridRegister.Children.Add(new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Paso 2: Ubicación",
            //    FontSize = 14,
            //    Margin = new Thickness(0, 20, 0, 0)
            //}, 0, 3, 1, 2);

            PickerCustom PickerEstado = new PickerCustom()
            {
                Margin = new Thickness(0),
                FontSize = 12,
                SelectedIndex = -1,
                Title = "Estado"
            };
            //PickerEstado.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickEstado));

            var FramePickerEstado = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(20, 40, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                WidthRequest = (App.screenWidth / 2.2),
                Content = PickerEstado
            };
            GridRegister.Children.Add(FramePickerEstado, 0, 3, 0, 1);

            PickerCustom PickerMunicipio = new PickerCustom()
            {
                Margin = new Thickness(0),
                FontSize = 12,
                SelectedIndex = -1,
                Title = "Municipio"
            };
            //PickerMunicipio.SetBinding(PickerCustom.ItemsSourceProperty, nameof(RegisterStepTwoViewModel.pickMunicipio));

            var FramePickerMunicipio = new Frame()
            {
                Padding = new Thickness(0),
                BackgroundColor = Color.White,
                Margin = new Thickness(20, 30, 20, 0),
                BorderColor = Color.Transparent,
                IsClippedToBounds = true,
                CornerRadius = 10,
                WidthRequest = (App.screenWidth / 2.2),
                Content = PickerMunicipio
            };

            GridRegister.Children.Add(FramePickerMunicipio, 0, 3, 1, 2);

            //var EntryDireccion = new CustomEditor()
            //{
            //    FontSize = 12,
            //    HeightRequest = 72,
            //    Margin = new Thickness(10, 0, 10, 0),
            //    Placeholder = "Dirección"
            //};

            //var FrameEntryDireccion = new Frame()
            //{
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.White,
            //    Margin = new Thickness(20, 30, 20, 0),
            //    BorderColor = Color.Transparent,
            //    IsClippedToBounds = true,
            //    CornerRadius = 10,
            //    Content = EntryDireccion
            //};
            //GridRegister.Children.Add(FrameEntryDireccion, 0, 3, 4, 5);

            var LabelButtonRegister = new Label()
            {
                FontSize = 14,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(0),
                TextColor = Color.White,
                Text = "Filtrar"
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
                BackgroundColor = Color.FromHex("#4f29B8"),
                BorderColor = Color.Transparent,
                HeightRequest = 40,
                VerticalOptions = LayoutOptions.Center,
                Content = GridButtonRegister
            };

            //TapGestureRecognizer tapButtonSiguiente = new TapGestureRecognizer();
            //tapButtonSiguiente.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepTwoViewModel.SiguienteCommand));
            //frameButtonRegister.GestureRecognizers.Add(tapButtonSiguiente);

            GridRegister.Children.Add(frameButtonRegister, 0, 3, 2, 3);

            //var LabelButtonVolver = new Label()
            //{
            //    FontSize = 14,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    Margin = new Thickness(0),
            //    TextColor = Color.White,
            //    Text = "Volver"
            //};

            //var GridVolverBoton = new Grid()
            //{
            //    BackgroundColor = Color.Transparent,
            //    VerticalOptions = LayoutOptions.Center
            //};

            //GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });
            //GridVolverBoton.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //GridVolverBoton.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //GridVolverBoton.Children.Add(LabelButtonVolver, 1, 0);

            //var frameButtonVolver = new Frame()
            //{
            //    Margin = new Thickness(20, 15, 20, 30),
            //    Padding = new Thickness(0),
            //    BackgroundColor = Color.FromHex("#F80061"),
            //    BorderColor = Color.Transparent,
            //    HeightRequest = 40,
            //    VerticalOptions = LayoutOptions.Center,
            //    Content = GridVolverBoton
            //};

            //TapGestureRecognizer tapButtonVolver = new TapGestureRecognizer();
            //tapButtonVolver.SetBinding(TapGestureRecognizer.CommandProperty, nameof(RegisterStepTwoViewModel.VolverCommand));
            //frameButtonVolver.GestureRecognizers.Add(tapButtonVolver);

            //GridRegister.Children.Add(frameButtonVolver, 0, 3, 6, 7);

            //GridMain.Children.Add(GridLogin, 0, 3, 2, 3);
            //GridMain.Children.Add(GridRegister, 0, 3, 2, 3);
            #endregion

            ListViewMenu.Header = new StackLayout
            {
                Children =
                {
                    imgProfile,
                    LabelUserName,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Margin = new Thickness(20, 10),
                        Spacing = 10,
                        Children =
                        {
                            FiltrarIcon,
                            filtrar
                        }
                    },
                    new Frame()
                    {
                        Padding = new Thickness(10),
                        BackgroundColor = Color.White,
                        BorderColor = Color.Black,
                        IsClippedToBounds = true,
                        CornerRadius = 10,
                        Content = GridRegister
                    }
                }
            };


            //var IconLogoTapGest = new TapGestureRecognizer();
            //var ListViewMenu = new ListView
            //{
            //    RowHeight = 45,
            //    HeaderTemplate = new DataTemplate(() =>
            //    {
            //        CircleImage IconLogo = new CircleImage
            //        {
            //            BorderColor = Color.FromHex("#E5E7E9"),
            //            BorderThickness = 1,
            //            Aspect = Aspect.AspectFill,
            //            Margin = new Thickness(0, 20, 0, 0),
            //            HeightRequest = 60,
            //            WidthRequest = 60,
            //            Source = ImageSource.FromResource("TuFarmaApp.Img.no-picture-user.jpg"),
            //            BackgroundColor = Color.Black
            //        };

            //        var LabelUserName = new Label
            //        {
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            //            FontAttributes = FontAttributes.Bold,
            //            VerticalTextAlignment = TextAlignment.Center,
            //            Text = "Darwin Sansonetti"
            //        };

            //        //IconLogo.GestureRecognizers.Add(IconLogoTapGest);

            //        //LabelUserName.SetBinding(Label.TextProperty, nameof(UserModel.name));

            //        var imgProfile = new CircleImage
            //        {
            //            BorderColor = Color.FromHex("#E5E7E9"),
            //            BorderThickness = 1,
            //            HorizontalOptions = LayoutOptions.Center,
            //            Aspect = Aspect.AspectFill,
            //            HeightRequest = 150,
            //            WidthRequest = 150,
            //            Source = ImageSource.FromResource("TuFarmaApp.Img.Cam.png"),
            //            //Margin = new Thickness(0, 30, 0, 60),
            //        };
            //        //var img = new CachedImage();
            //        //imgProfile.SetBinding(CircleImage.SourceProperty, nameof(UserModel.picture));

            //        Grid grid = new Grid
            //        {
            //            Margin = new Thickness(20, 20, 20, 0),
            //        };
            //        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
            //        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //        grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(40) });
            //        grid.Children.Add(LabelUserName, 1, 0);
            //        grid.Children.Add(imgProfile, 2, 0);

            //        return new StackLayout
            //        {
            //            Children =
            //            {
            //                IconLogo,
            //                grid
            //            }
            //        };
            //    }),
            //    ItemsSource = new List<string>
            //    {
            //        "texto1",
            //        "Texto2",
            //        "Texto3"
            //        //new MenuModel
            //        //{
            //        //    Text = "Información personal",
            //        //    Icon =  "Chappsy2.Img.UserIcon.Usuario.svg",
            //        //    PageName = nameof(InfoUser)
            //        //},
            //        ////new MenuModel
            //        ////{
            //        ////    Text = "Métodos de pago",
            //        ////    Icon =  "Chappsy2.Img.UserIcon.Wallet.svg",
            //        ////    PageName = nameof(MethodPay)
            //        ////},
            //        //new MenuModel
            //        //{
            //        //    Text = "Carrito de compras",
            //        //    Icon =  "Chappsy2.Img.UserIcon.commerce-and-shopping.svg",
            //        //    PageName = nameof(Carrito)
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Direcciones de envío",
            //        //    Icon =  "Chappsy2.Img.UserIcon.Direcciones.svg",
            //        //    PageName = nameof(Addres)
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Mis compras",
            //        //    Icon =  "Chappsy2.Img.UserIcon.MisCompras.svg",
            //        //    PageName = nameof(MisCompras)
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Mis ventas",
            //        //    Icon =  "Chappsy2.Img.UserIcon.venta.svg",
            //        //    PageName = $"{nameof(MySalesTabPage)}"
            //        //    //PageName = $"{nameof(MySalesTabPage)}/{nameof(MySalesPage)}"
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Lugares de reparto",
            //        //    Icon =  "Chappsy2.Img.UserIcon.gps.svg",
            //        //    PageName = $"{nameof(RouteBuy1)}"
            //        //    //PageName = $"{nameof(MySalesTabPage)}/{nameof(MySalesPage)}"
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Crea tu tienda web",
            //        //    Icon =  "Chappsy2.Img.UserIcon.smartphone.svg",
            //        //    PageName = nameof(NewShop)
            //        //    //PageName = nameof(DetailBuy)
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Información general",
            //        //    Icon =  "Chappsy2.Img.UserIcon.Info.svg",
            //        //    PageName = nameof(InfoGeneral)
            //        //},
            //        //new MenuModel
            //        //{
            //        //    Text = "Cerrar sesión",
            //        //    Icon =  "Chappsy2.Img.UserIcon.saliir.svg",
            //        //    PageName = nameof(LoginPage)
            //        //},
            //    },
            //    ItemTemplate = new DataTemplate(() =>
            //    {
            //        SvgCachedImage ButtonIcon = new SvgCachedImage
            //        {
            //            HorizontalOptions = LayoutOptions.Start,
            //            HeightRequest = 18,
            //            WidthRequest = 18,
            //            Source = "resource://TuFarmaApp.Img.Svg.conversation.svg",
            //        };
            //        //ButtonIcon.SetBinding(SvgCachedImage.SourceProperty,
            //        //    nameof(MenuModel.Icon),
            //        //    stringFormat: "resource://{0:F2}");

            //        Label label = new Label
            //        {
            //            VerticalTextAlignment = TextAlignment.Center,
            //            FontSize = size,
            //            Text = "Texto"
            //        };
            //        //label.SetBinding(Label.TextProperty, nameof(MenuModel.Text));

            //        return new ViewCell
            //        {
            //            View = new StackLayout
            //            {
            //                Orientation = StackOrientation.Horizontal,
            //                Margin = new Thickness(20, 10),
            //                Spacing = 10,
            //                Children =
            //                {
            //                    ButtonIcon,
            //                    label
            //                }
            //            }
            //        };
            //    })
            //};
            //ListViewMenu.SetBinding(ListView.HeaderProperty, nameof(MenuPageViewModel.userSession));

            //var ListViewTapCommand = new EventToCommandBehavior
            //{
            //    EventName = nameof(ListView.ItemTapped),
            //    EventArgsParameterPath = nameof(ItemTappedEventArgs.Item)
            //};
            //ListViewTapCommand.SetBinding(EventToCommandBehavior.CommandProperty, nameof(MenuPageViewModel.CommandMenuTap));
            //ListViewMenu.Behaviors.Add(ListViewTapCommand);

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