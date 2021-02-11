using System;
using System.Net;
using Android.App;
using Android.Runtime;
using FFImageLoading;

namespace TuFarmaApp.Droid
{
    [Application(
        Theme = "@style/MainTheme"
        )]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);

            #region FFImageLoading
            var ignore = typeof(FFImageLoading.Svg.Forms.SvgCachedImage);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);

            // Esto es Probando el modernHttpClient-Update
            //var messageHandler = new NativeMessageHandler()
            //{
            //    Timeout = new TimeSpan(0, 0, 60),
            //};
            //ImageService.Instance.InvalidateMemoryCache();

            //var httpClient = new HttpClient(new AndroidClientHandler()
            //{
            //    //AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
            //    AutomaticDecompression = DecompressionMethods.GZip,
            //});

            ////HttpClient httpClient = new HttpClient(messageHandler);
            ////HttpClient httpClient = new HttpClient(new Xamarin.Android.Net.AndroidClientHandler());
            //var config = new FFImageLoading.Config.Configuration()
            //{
            //    HttpClient = httpClient,
            //    FadeAnimationEnabled = true,
            //    //FadeAnimationDuration = 500,
            //    FadeAnimationDuration = 100,
            //};
            //ImageService.Instance.Initialize(config);
            #endregion
        }
    }
}
