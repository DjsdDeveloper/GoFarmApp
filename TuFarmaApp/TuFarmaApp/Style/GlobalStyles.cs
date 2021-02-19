using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TuFarmaApp.Styles
{
    public class GlobalStyles : ResourceDictionary
    {
        //public static readonly ImageSource LogoPath = ImageSource.FromResource("TuFarmaApp.Img.GoFarmapp2.png";
        public static readonly string PrimaryColorHex = "#04554C";

        public static readonly Color PrimaryColor = Color.FromHex(PrimaryColorHex);
        public static readonly Color SecondColor = Color.FromHex("#81b71b");

        public GlobalStyles()
        {
            var Bar = new Style(typeof(NavigationPage))
            {
                Setters =
                {
                    new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = PrimaryColor },
                    new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.White },
                }
            };
            var contentPage = new Style(typeof(ContentPage))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new Setter { Property = VisualElement.BackgroundColorProperty, Value = Color.White },
                }
            };
            var PrimaryButton = new Style(typeof(Button))
            {
                Setters =
                {
                    new Setter { Property = VisualElement.BackgroundColorProperty, Value = SecondColor },
                    new Setter { Property = Button.TextColorProperty, Value = Color.White }
                }
            };
            var InputLabel = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.TextColorProperty, Value = Color.Black },
                    //new Setter { Property = Label.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    new Setter { Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Small, typeof(Label))},
                }
            };
            var TituloLabel = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.HorizontalTextAlignmentProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.VerticalTextAlignmentProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    //new Setter { Property = Label.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    new Setter { Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Large, typeof(Label))},
                }
            };
            var SubTituloLabel = new Style(typeof(Label))
            {
                Setters =
                {
                    new Setter { Property = Label.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.HorizontalTextAlignmentProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.VerticalTextAlignmentProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    //new Setter { Property = Label.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    new Setter { Property = Label.FontSizeProperty, Value = Device.GetNamedSize(NamedSize.Medium, typeof(Label))},
                }
            };
            var entry = new Style(typeof(Entry))
            {
                Setters =
                {
                    new Setter { Property = VisualElement.BackgroundColorProperty , Value = Color.White },
                    //new Setter { Property = Entry.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    new Setter { Property = Entry.PlaceholderColorProperty, Value = Color.FromHex("#bfbdbd")},
                }
            };
            var editor = new Style(typeof(Editor))
            {
                Setters =
                {
                    new Setter { Property = VisualElement.BackgroundColorProperty , Value = Color.White },
                    //new Setter { Property = Editor.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    //new Setter { Property = Editor.PlaceholderColorProperty, Value = Color.FromHex("#bfbdbd")},
                }
            };
            var frame = new Style(typeof(Frame))
            {
                Setters =
                {
                    new Setter { Property = Frame.HasShadowProperty , Value = false },
                    //new Setter { Property = Editor.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                    //new Setter { Property = Editor.PlaceholderColorProperty, Value = Color.FromHex("#bfbdbd")},
                }
            };
            var picker = new Style(typeof(Picker))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new Setter { Property = VisualElement.BackgroundColorProperty , Value = Color.White },
                    //new Setter { Property = Picker.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                }
            };
            var Tabs = new Style(typeof(TabbedPage))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new Setter { Property = TabbedPage.BarBackgroundColorProperty , Value = PrimaryColor },
                    new Setter { Property = TabbedPage.BarTextColorProperty , Value = Color.White },
                    //new Setter { Property = TabbedPage.BarTextColorProperty , Value = Color.Black },
                    //new Setter { Property = Picker.FontFamilyProperty, Value = "Nunito-Regular.ttf#"},
                }
            };

            //var cachedImage = new Style(typeof(FFImageLoading.Forms.CachedImage))
            //{
            //    Setters =
            //    {
            //        new Setter { Property = FFImageLoading.Forms.CachedImage.ErrorPlaceholderProperty, Value = "resource://Chappsy2.Img.img404.png" },
            //        new Setter { Property = FFImageLoading.Forms.CachedImage.RetryCountProperty, Value = 5 },
            //        new Setter { Property = FFImageLoading.Forms.CachedImage.RetryDelayProperty, Value = 100 },
            //    }
            //};

            //Add(cachedImage);
            Add(Bar);
            Add(contentPage);
            Add(entry);
            Add(editor);
            Add(frame);
            Add(picker);
            Add(Tabs);
            Add("PrimaryButton", PrimaryButton);
            Add("InputLabel", InputLabel);
            Add("TituloLabel", TituloLabel);
            Add("SubTituloLabel", SubTituloLabel);
            Add("SecondChappsyColor", SecondColor);
            Add("PrimaryChappsyColor", PrimaryColor);
            Add("ChappsyGray", Color.FromHex("#bfbdbd"));

        }
    }
}
