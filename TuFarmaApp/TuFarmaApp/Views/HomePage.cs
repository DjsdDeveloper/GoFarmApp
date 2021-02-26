using CarouselView.FormsPlugin.Abstractions;
using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.Models;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{
    public class CellView2 : Grid
    {
        CachedImage image;
        CachedImage LogoAvatar;

        public CellView2(Page page)
        {
            RowSpacing = 0;
            HeightRequest = 500;
            Resources.Add("margin", new Thickness(10, 0));

            //#region Guardar Producto
            //var save = new FavoriteButton();
            //save.SetBinding(FavoriteButton.IsActivedProperty, nameof(ProductModel.IsFavorite));
            //save.SetBinding(FavoriteButton.IsLoadingProperty, nameof(ProductModel.IsBusy));
            //save.SetBinding(FavoriteButton.CommandParameterProperty, ".");
            //save.SetBinding(FavoriteButton.CommandProperty, new Binding
            //{
            //    Source = page.BindingContext,
            //    Path = nameof(MarketMainPageD2ViewModel.SaveCommand)
            //});
            //#endregion

            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            this.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

            //#region TopBar
            //var LabelVendedor = new Label
            //{
            //    Margin = new Thickness(0, 10, 0, 0),
            //    FontSize = 20,
            //    VerticalTextAlignment = TextAlignment.Start
            //};
            //LabelVendedor.SetBinding(Label.TextProperty,
            //    $"{nameof(ProductModel.storeData)}.{nameof(ProductModel.storeData.name)}");

            //LogoAvatar = new CachedImage
            //{
            //    VerticalOptions = LayoutOptions.Start,
            //    Margin = new Thickness(0, 10, 0, 0),
            //    Aspect = Aspect.AspectFit,
            //    Transformations = new List<FFImageLoading.Work.ITransformation>
            //    {
            //        new CircleTransformation()
            //    },
            //    HeightRequest = 40,
            //    WidthRequest = 40,
            //    //Source = EmbeddedResourceImageSource.FromResource("Chappsy2.Img.UserIcon.LogoC.png"),
            //    DownsampleToViewSize = true,
            //};
            //var avatarTgr = new TapGestureRecognizer();
            //avatarTgr.SetBinding(TapGestureRecognizer.CommandParameterProperty, ".");
            //avatarTgr.SetBinding(TapGestureRecognizer.CommandProperty, new Binding
            //{
            //    Source = page.BindingContext,
            //    Path = nameof(MarketMainPageD2ViewModel.GoStoreCommand)
            //});
            //LogoAvatar.GestureRecognizers.Add(avatarTgr);
            //LabelVendedor.GestureRecognizers.Add(avatarTgr);

            ////var shawdonw = new PancakeView
            ////{

            ////    HasShadow = true
            ////};

            //var stackingAvatar = new StackLayout
            //{
            //    Children =
            //    {
            //        new BoxView
            //        {
            //            Style = (Style)page.Resources["separator"]
            //        },
            //        new StackLayout
            //        {
            //            Padding = new Thickness(10, 0, 0, 10),
            //            Orientation = StackOrientation.Horizontal,
            //            Children =
            //            {
            //                LogoAvatar,
            //                LabelVendedor,
            //                save
            //            }
            //        }
            //    }
            //};
            //#endregion
            //this.Children.Add(stackingAvatar, 0, 1, 0, 1);

            image = new CachedImage
            {
                //DownsampleWidth = 200,
                Aspect = Aspect.AspectFill,
                //HeightRequest = 400,
                BackgroundColor = Color.FromHex("#f5f5f5"),
            };

            Label nameLabel = new Label
            {
                Margin = new Thickness(10, 10, 10, 0),
                //Style = (Style)App.Current.Resources["title"],
                //MaxLines = 1,
                LineBreakMode = LineBreakMode.TailTruncation,
                FontAttributes = FontAttributes.Bold,
                //BackgroundColor = Color.White
            };
            nameLabel.SetBinding(Label.TextProperty, "Title");

            //Label LabelDescripcion = new Label
            //{
            //    Margin = (Thickness)Resources["margin"],
            //    FontSize = 12,
            //    LineBreakMode = LineBreakMode.TailTruncation,
            //    //TextType = TextType.Html
            //};
            //LabelDescripcion.SetBinding(Label.TextProperty, nameof(ProductModel.short_description));

            //Label PriceLabel = new Label
            //{
            //    Margin = (Thickness)Resources["margin"],
            //    FontAttributes = FontAttributes.Italic,
            //};
            //PriceLabel.SetBinding(Label.TextProperty, "Price",
            //    converter: new ToQuetzalConvert());

            this.Children.Add(image, 0, 1, 1, 2);

            this.Children.Add(nameLabel, 0, 1, 2, 3);
            //this.Children.Add(LabelDescripcion, 0, 1, 3, 4);
            //this.Children.Add(PriceLabel, 0, 1, 4, 5);

            //#region ProductoTap
            //TapGestureRecognizer tgr = new TapGestureRecognizer();
            //tgr.SetBinding(TapGestureRecognizer.CommandProperty,
            //new Binding
            //{
            //    Path = nameof(MarketMainPageD2ViewModel.ProductoTap),
            //    Source = page.BindingContext
            //});
            //tgr.SetBinding(TapGestureRecognizer.CommandParameterProperty, ".");
            //image.GestureRecognizers.Add(tgr);
            //#endregion
        }
        protected override void OnBindingContextChanged()
        {
            image.Source = null;
            //LogoAvatar.Source = null;
            //LogoAvatar.Source = null;
            var context = (ProductModel)BindingContext;
            if (context != null)
            {
                //var rezi = new Models.ResizeImgModel2();

                //rezi.edits.resize.width = 50;
                //image.Source = rezi.Resizer(context.MainImage);

                //rezi.edits.resize.width = 1;
                Debug.WriteLine(context.MainImage);
                image.Source = context.MainImage;
                //image.LoadingPlaceholder = context.Thumbnail;
                //LogoAvatar.Source = context.storeData.photoUrl;
                //LogoAvatar.Source = context.storeData.photoUrl;
            }

            base.OnBindingContextChanged();
        }
    }

    public class HomePage : ContentPage
    {
        CollectionView ProductosView2;

        public HomePage()
        {
            #region NAVIGATION PAGE
            var SearchBar = new CustomEntry
            {
                Margin = new Thickness(10, 0, 0, 0),
                FontSize = 12,
                Placeholder = "Buscar producto",
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

            #region Declaracion lista de productos
            ProductosView2 = new CollectionView
            {
                SelectionMode = SelectionMode.None,
                ItemsLayout = LinearItemsLayout.Vertical,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 0, 0, 0),
                ItemTemplate = new DataTemplate(() => new CellView2(this)),
                RemainingItemsThreshold = 0,
                IsVisible = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Never
            };

            ProductosView2.SetBinding(CollectionView.ItemsSourceProperty,
                nameof(HomePageViewModel.Products));

            var HeaderTemplate = new DataTemplate(() =>
            {
                #region Carousel Principal

                //var tapGestureRecognizer = new TapGestureRecognizer();
                CarouselViewControl carouselView = new CarouselViewControl
                {
                    Margin = new Thickness(0, 5, 0, 5),
                    ShowIndicators = true,
                    ItemTemplate = new DataTemplate(() =>
                    {
                        var img = new CachedImage() 
                        {
                            Aspect = Aspect.AspectFill,
                        };
                        img.SetBinding(CachedImage.SourceProperty, ".");
                        //img.GestureRecognizers.Add(tapGestureRecognizer);

                        return img;
                    })
                };
                carouselView.SetBinding(CarouselViewControl.ItemsSourceProperty, nameof(HomePageViewModel.Carouselsourse));

                Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
                {
                    carouselView.Position = (carouselView.Position + 1) % App.IndexSetting;

                    return true;
                }));

                //var img = new CachedImage
                //{
                //    Aspect = Aspect.AspectFill,
                //    Source = ImageSource.FromResource("TuFarmaApp.Img.BannerHome.1.jpg")
                //};
                //var rezi = new Models.ResizeImgModel2();
                //rezi.edits.resize.width = 300;
                //img.SetBinding(CachedImage.SourceProperty, ".", converter: new Helpers.Converters.ResizeConvert(rezi));

                //var rezi2 = new Models.ResizeImgModel2();
                //rezi2.edits.resize.width = 1;
                //img.SetBinding(CachedImage.LoadingPlaceholderProperty, ".", converter: new Helpers.Converters.ResizeConvert(rezi2));
                //return img;

                Grid ProductLayout = new Grid();

                ProductLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(170, GridUnitType.Absolute) });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //ProductLayout.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                //tapGestureRecognizer.Tapped += (s, e) =>
                //{
                //    var list = new List<Photo>();
                //    var max = carouselView.ItemsSource.GetCount();
                //    for (int i = 0; i < max; i++)
                //    {
                //        list.Add(new Photo
                //        {
                //            URL = (string)carouselView.ItemsSource.GetItem(i),
                //            Title = $"{i + 1} de {max}"
                //        });
                //    }

                //    new PhotoBrowser
                //    {
                //        ActionButtonPressed = (index) =>
                //        {
                //            PhotoBrowser.Close();
                //        },
                //        StartIndex = carouselView.Position,
                //        Photos = list,
                //        BackgroundColor = Color.Black,
                //    }.Show();
                //};

                #endregion




                //var categories = new CollectionView
                //{
                //    HeightRequest = 90,
                //    Margin = new Thickness(0, BarHeigth + 10, 0, 0),
                //    SelectionMode = SelectionMode.None,
                //    ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Horizontal)
                //    {
                //        ItemSpacing = 5
                //    },
                //    ItemTemplate = new DataTemplate(() => new CellCategories(this))
                //};
                //categories.SetBinding(CollectionView.ItemsSourceProperty, nameof(MarketMainPageD2ViewModel.Categories));

                //var sellButton = new ButtonIcon()
                //{
                //    //Margin = new Thickness(0, 20, 10, 20),
                //    Margin = new Thickness(0, 10, 10, 10),
                //};
                //sellButton.text.Text = "¿Qué quieres vender hoy?";
                //sellButton.icon.Source = "resource://Chappsy2.Img.UserIcon.billete2.svg";
                //sellButton.icon.ReplaceStringMap = new Dictionary<string, string> { { "ffffff", "ffffff" } };
                //sellButton.tap.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MarketMainPageD2ViewModel.ButtonVenderCommand));

                //var LogoC = new CircleImage
                //{
                //    Margin = new Thickness(10, 0, 0, 0),
                //    HorizontalOptions = LayoutOptions.Center,
                //    Aspect = Aspect.AspectFill,
                //    HeightRequest = 40,
                //    WidthRequest = 40,
                //};
                //LogoC.SetBinding(CircleImage.SourceProperty, nameof(MarketMainPageD2ViewModel.picture));

                //var gifts = new GiftsView();
                //gifts.SetBinding(GiftsView.ItemsSourceProperty, nameof(MarketMainPageD2ViewModel.Gifts));
                //gifts.SetBinding(GiftsView.CommandProperty, nameof(MarketMainPageD2ViewModel.ProductoTap));


                //var BannerTgr = new TapGestureRecognizer();
                //BannerTgr.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MarketMainPageD2ViewModel.BannerCommand));
                //var Banner = new CachedImage
                //{
                //    HeightRequest = App.screenWidth * 0.817,
                //    Source = EmbeddedResourceImageSource.FromResource("Chappsy2.Img.Market.Banner.png")
                //};
                //Banner.GestureRecognizers.Add(BannerTgr);

                //var h = new Grid
                //{
                //    RowSpacing = 0,
                //    ColumnSpacing = 20,
                //};
                //h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                //h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                //h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ////h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                ////h.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

                //h.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                //h.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                //h.Children.Add(new BoxView { Style = (Style)Resources["separator"] }, 0, 2, 0, 1);
                //h.Children.Add(LogoC, 0, 1, 1, 2);
                //h.Children.Add(sellButton, 1, 2, 1, 2);
                //h.Children.Add(new BoxView { Style = (Style)Resources["separator"] }, 0, 2, 2, 3);

                ////h.Children.Add(Stories, 0, 2, 3, 4);
                ////h.Children.Add(new BoxView { Style = (Style)Resources["separator"] }, 0, 2, 4, 5);

                ////h.Children.Add(Gfood, 0, 2, 5, 6);
                //h.Children.Add(Banner, 0, 2, 3, 4);
                //h.Children.Add(gifts, 0, 2, 4, 5);

                //h.SetBinding(View.IsVisibleProperty, nameof(MarketMainPageD2ViewModel.IsvisbleOnlyCategories), converter: new InvertBoolConvert());
                //CompressedLayout.SetIsHeadless(h, true);

                ProductLayout.Children.Add(carouselView, 0, 2, 0, 1);

                //return new StackLayout
                //{
                //    Spacing = -6,
                //    Children =
                //    {
                //        carouselView
                //        //categories,
                //        //h
                //    }
                //};

                return ProductLayout;
            });
            ProductosView2.HeaderTemplate = HeaderTemplate;
            ProductosView2.SetBinding(CollectionView.HeaderProperty, new Binding { Source = this, Path = "BindingContext" });
            #endregion

            Content = ProductosView2;
        }
    }
}