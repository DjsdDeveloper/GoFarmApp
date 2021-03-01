using CarouselView.FormsPlugin.Abstractions;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuFarmaApp.CustomRender;
using TuFarmaApp.Models;
using TuFarmaApp.ViewModels;
using Xamarin.Forms;

namespace TuFarmaApp.Views
{

    public class CellMain : Grid
    {
        CachedImage image;
        CachedImage LogoAvatar;

        public CellMain(Page page)
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

    public class MainHome : ContentPage
    {
        CollectionView ProductosView2;
        double OldVerticalOffSet = 0;
        //Image btnReaccion;
        View header;
        MenuBottom menuBottom;
        TapGestureRecognizer scrollUpTap;

        public MainHome()
        {
            var IPhone = Device.Idiom == TargetIdiom.Phone;
            var BarHeigth = Device.RuntimePlatform == Device.iOS ? 44 : 56;

            Resources.Add("separator", new Style(typeof(View))
            {
                Setters =
                {
                    new Setter{ Property = View.HeightRequestProperty, Value = 4 },
                    new Setter{ Property = View.BackgroundColorProperty, Value = Color.FromHex("#f2f1f1") },
                }
            });

            #region NAVIGATION PAGE
            NavigationPage.SetHasNavigationBar(this, false);
            #endregion

            #region HOME 

            ProductosView2 = new CollectionView
            {
                SelectionMode = SelectionMode.None,
                ItemsLayout = LinearItemsLayout.Vertical,
                BackgroundColor = Color.White,
                Margin = new Thickness(0, 0, 0, 0),
                ItemTemplate = new DataTemplate(() => new CellMain(this)),
                RemainingItemsThreshold = 0,
                IsVisible = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Never
            };
            var HeaderTemplate = new DataTemplate(() =>
            {
                //#region Carousel Principal

                //var tapGestureRecognizer = new TapGestureRecognizer();
                CarouselViewControl carouselView = new CarouselViewControl
                {
                    //Margin = new Thickness(0, 25, 0, 5),
                    Margin = new Thickness(0, BarHeigth + 10, 0, 5),
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
                carouselView.SetBinding(CarouselViewControl.ItemsSourceProperty, nameof(MainHomeViewModel.Carouselsourse));

                Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
                {
                    carouselView.Position = (carouselView.Position + 1) % App.IndexSetting;

                    return true;
                }));

                Grid ProductLayout = new Grid();

                ProductLayout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(210, GridUnitType.Absolute) });

                ProductLayout.Children.Add(carouselView, 0, 2, 0, 1);

                return ProductLayout;
            });
            ProductosView2.HeaderTemplate = HeaderTemplate;
            ProductosView2.SetBinding(CollectionView.HeaderProperty, new Binding { Source = this, Path = "BindingContext" });

            ProductosView2.SetBinding(CollectionView.ItemsSourceProperty,nameof(MainHomeViewModel.Products));

            //ProductosView2.SetBinding(CollectionView.RemainingItemsThresholdReachedCommandProperty, nameof(MarketMainPageD2ViewModel.ItemAppearing));

            ProductosView2.Scrolled += OnCollectionViewScrolled;




            var ConectivityMessage = new TuFarmaApp.CustomRender.ConectivityMessage();
            ConectivityMessage.SetBinding(View.IsVisibleProperty, nameof(MainHomeViewModel.IsConectivityDisable));
            //ConectivityMessage.Tap.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MarketMainPageD2ViewModel.RetryTapped));


            #region Bar
            var headerGrid = new Grid
            {
                Padding = new Thickness(10, 0)
            };
            headerGrid.SizeChanged += (s, e) => Debug.WriteLine("Bar " + ((View)s).Height);
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            headerGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            var chappsy = new SvgCachedImage
            {
                DownsampleHeight = 72,
                Source = "resource://TuFarmaApp.Img.Svg.calendario.svg"
            };
            headerGrid.Children.Add(chappsy);
            scrollUpTap = new TapGestureRecognizer();
            chappsy.GestureRecognizers.Add(scrollUpTap);

            var search = new CachedImage
            {
                Aspect = Aspect.AspectFit,
                WidthRequest = 25,
                DownsampleWidth = 60,
                Source = EmbeddedResourceImageSource.FromResource("TuFarmaApp.Img.lupa.png"),
            };
            //var searchtgr = new TapGestureRecognizer();
            //searchtgr.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MarketMainPageD2ViewModel.GoSearchPage));
            //search.GestureRecognizers.Add(searchtgr);

            var shoppingcart = new CachedImage
            {
                Margin = new Thickness(10, 0, 0, 0),
                Aspect = Aspect.AspectFit,
                WidthRequest = 25,
                DownsampleWidth = 60,
                Source = EmbeddedResourceImageSource.FromResource("TuFarmaApp.Img.lupa.png")
            };
            //var shoppingtgr = new TapGestureRecognizer();
            //shoppingtgr.SetBinding(TapGestureRecognizer.CommandProperty, nameof(MarketMainPageD2ViewModel.GoShoppingCart));
            //shoppingcart.GestureRecognizers.Add(shoppingtgr);

            headerGrid.Children.Add(search, 2, 0);
            headerGrid.Children.Add(shoppingcart, 3, 0);

            header = new Frame
            {
                Content = headerGrid,
                HeightRequest = BarHeigth + 5,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.FromHex("#0B3C93"),
            };

            #endregion


            #region MenuBottom
            menuBottom = new MenuBottom(this, nameof(MainHomeViewModel.MenuCommand));
            menuBottom.ItemsSource[0].IsActive = true;
            #endregion

            #region MainContainer
            var g = new Grid
            {
                RowSpacing = 0,
            };
            g.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            g.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            g.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });


            g.Children.Add(ProductosView2, 0, 1, 0, 3);

            g.Children.Add(header, 0, 0);
            g.Children.Add(menuBottom, 0, 2);
            g.Children.Add(ConectivityMessage, 0, 1);

            #endregion

            CompressedLayout.SetIsHeadless(g, true);

            //menuBottom.SetBinding(View.IsVisibleProperty, nameof(MarketMainPageD2ViewModel.IsSearhResult), converter: new Helpers.Converters.InvertBoolConvert());
            //this.SetBinding(NavigationPage.HasNavigationBarProperty, nameof(MarketMainPageD2ViewModel.IsSearhResult));
            //this.SetBinding(ContentPage.TitleProperty, nameof(MarketMainPageD2ViewModel.SearchQuery));
            //ProductosView2.SetBinding(CollectionView.HeaderProperty, nameof(MarketMainPageD2ViewModel.ViewMdodel));

            Content = g;






            //ProductosView2.SizeChanged += (s, e) =>
            //{
            //    Debug.WriteLine("ProductosView2 " + ((View)s).Height);
            //};

            

            //ProductosView2.SetBinding(CollectionView.RemainingItemsThresholdReachedCommandProperty, nameof(MarketMainPageD2ViewModel.ItemAppearing));

            //ProductosView2.Scrolled += OnCollectionViewScrolled;
            #endregion


            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label { Text = "Welcome to Xamarin.Forms!" }
            //    }
            //};
            //}
        }

        async void OnCollectionViewScrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            List<Task<bool>> animations = new List<Task<bool>>();

            if (e.VerticalOffset > 62 && e.VerticalOffset > OldVerticalOffSet)
            {
                Debug.WriteLine("BAJANDO");
                animations.Add(header.TranslateTo(0, -header.Height, 200));
                animations.Add(menuBottom.TranslateTo(0, menuBottom.Height, 200));
            }
            else
            {
                Debug.WriteLine("SUBIENDO");
                animations.Add(header.TranslateTo(0, 0, 200));
                animations.Add(menuBottom.TranslateTo(0, 0, 200));
            }
            OldVerticalOffSet = e.VerticalOffset;

            await Task.WhenAll(animations);
        }

    }
}