using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TuFarmaApp.CustomRender
{
    class ConectivityMessage : ContentView
    {
        public TapGestureRecognizer Tap;

        public ConectivityMessage()
        {
            Padding = Margin = 0;
            BackgroundColor = Color.White;
            var NoWifiSvg = new SvgCachedImage
            {
                HeightRequest = 64,
                WidthRequest = 64,
                Source = "resource://TuFarmaApp.Img.Svg.no-wifi.svg",
            };
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };
            layout.Children.Add(NoWifiSvg);
            layout.Children.Add(new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Revise su conexion a internet"
            });

            Tap = new TapGestureRecognizer();
            layout.GestureRecognizers.Add(Tap);
            Content = layout;
        }
    }
}
