using FFImageLoading.Forms;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
namespace TuFarmaApp.CustomRender
{
    public class MenuBottom : FlexLayout
    {
        public class MenuBottomModel : INotifyPropertyChanged
        {
            public string Text { get; set; }

            [AlsoNotifyFor("ActiveIcon")]
            public bool IsActive { get; set; }
            public string ActiveIcon { get { return IsActive ? SelectedPath : DefaultPath; } }
            public string DefaultPath { get; set; }
            public string SelectedPath { get; set; }
            public int Option { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        public MenuBottomModel[] ItemsSource;

        public MenuBottom(Page context, string commandPath)
        {
            BackgroundColor = Color.White;
            JustifyContent = FlexJustify.SpaceEvenly;
            VerticalOptions = LayoutOptions.End;
            HeightRequest = 55;
            var DefaultPath = "resource://TuFarmaApp.Img.MenuBottom.Default.";
            var ActivedPath = "resource://TuFarmaApp.Img.MenuBottom.Actived.";

            ItemsSource = new MenuBottomModel[]
            {
                new MenuBottomModel {
                    Option = 0,
                    Text = "home".ToUpper(),
                    DefaultPath = DefaultPath + "Home.png",
                    SelectedPath = ActivedPath + "Home.png"
                },
                new MenuBottomModel {
                    Option = 1,
                    Text = "tiendas".ToUpper(),
                    DefaultPath = ActivedPath + "Tiendas.png",
                    SelectedPath = ActivedPath + "Tiendas.png"
                },
                new MenuBottomModel {
                    Option = 2,
                    Text = "".ToUpper(),
                    DefaultPath = DefaultPath + "Sell.png",
                    SelectedPath = DefaultPath + "Sell.png"
                },
                new MenuBottomModel {
                    Option = 3,
                    Text = "Setup".ToUpper(),
                    DefaultPath = ActivedPath + "Configurar.png",
                    SelectedPath = ActivedPath + "Configurar.png"
                },
                new MenuBottomModel {
                    Option = 4,
                    Text = "menú".ToUpper(),
                    DefaultPath = DefaultPath +"Menu.png",
                    SelectedPath = DefaultPath +"Menu.png"
                },
            };

            var widthCenter = App.screenWidth / ItemsSource.Length * 1.2 - 12;
            var width = App.screenWidth - widthCenter;

            var ItemTemplate = new DataTemplate(() =>
            {
                var label = new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = App.screenWidth < 320 ? 9 : 12
                };
                var img = new CachedImage
                {
                    HeightRequest = 26,
                    WidthRequest = 26,
                    Margin = new Thickness(0, 10, 0, 0),
                };
                img.SetBinding(CachedImage.SourceProperty, nameof(MenuBottomModel.ActiveIcon));
                var stack = new StackLayout
                {
                    Spacing = 0,
                    HorizontalOptions = LayoutOptions.Start,
                    WidthRequest = width / (ItemsSource.Length - 1) - 12,
                    Children = { img, label }
                };
                stack.BindingContextChanged += (s, e) =>
                {
                    var bin = (MenuBottomModel)((View)s).BindingContext;
                    if (bin != null)
                    {
                        if (bin.Text != "")
                            label.Text = bin.Text;
                        else
                        {
                            //img.BackgroundColor = Color.Red;
                            img.Margin = new Thickness(0, 5, 0, 0);
                            stack.WidthRequest = widthCenter;
                            img.HeightRequest = 45;
                            label.IsVisible = false;
                        }
                    }
                };

                var tgp = new TapGestureRecognizer();
                tgp.SetBinding(TapGestureRecognizer.CommandParameterProperty, "Option");
                tgp.SetBinding(TapGestureRecognizer.CommandProperty, new Binding
                {
                    Source = context.BindingContext,
                    Path = commandPath
                });

                stack.GestureRecognizers.Add(tgp);
                return stack;
            });
            BindableLayout.SetItemTemplate(this, ItemTemplate);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var bin = BindingContext;
            if (bin != null)
            {
                BindableLayout.SetItemsSource(this, ItemsSource);
            }
        }
    }
}