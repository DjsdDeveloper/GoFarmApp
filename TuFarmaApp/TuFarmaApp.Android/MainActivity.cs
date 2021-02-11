using Acr.UserDialogs;
using Android.App;
using Android.Content.PM;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace TuFarmaApp.Droid
{
    //[Activity(Label = "GoFarmapp", Icon = "@mipmap/GoApp", Theme = "@style/MainTheme", MainLauncher = true)]
    [Activity(Theme = "@style/MainTheme",
              ConfigurationChanges = ConfigChanges.ScreenSize |
              ConfigChanges.Orientation |
              ConfigChanges.UiMode |
              ConfigChanges.ScreenLayout |
              ConfigChanges.SmallestScreenSize, 
              MainLauncher = false)]
    //[Activity(Label = "GoFarmapp",
    //    Icon = "@drawable/LogoGoApp",
    //    //RoundIcon = "@drawable/chappsyicon_round",
    //    Theme = "@style/MainTheme",
    //    MainLauncher = true,
    //    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
    //    // BLOQUEA LA ROTACION
    //    ScreenOrientation = ScreenOrientation.Portrait
    //)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);


            //#region INICIALIZACION DE PAQUETES NUGGETS
            //UserDialogs.Init(this);
            //Forms.SetFlags("CarouselView_Experimental");
            //Rg.Plugins.Popup.Popup.Init(this);
            //#endregion


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //ImageCircleRenderer.Init();

            #region For screen Height & Width

            var pixels = Resources.DisplayMetrics.WidthPixels;
            var scale = Resources.DisplayMetrics.Density;

            var dps = (double)((pixels - 0.5f) / scale);

            var ScreenWidth = (int)dps;

            App.screenWidth = ScreenWidth;

            //RequestedOrientation = ScreenOrientation.Portrait;

            pixels = Resources.DisplayMetrics.HeightPixels;
            dps = (double)((pixels - 0.5f) / scale);

            var ScreenHeight = (int)dps;
            App.screenHeight = ScreenHeight;

            #endregion

            LoadApplication(new App(new AndroidInitializer()));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }
}

