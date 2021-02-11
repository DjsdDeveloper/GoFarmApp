using Android.App;
using Android.Content;
using Android.OS;
using AndroidX.AppCompat.App;

namespace TuFarmaApp.Droid
{
    [Activity(Theme = "@style/Theme.Splash", Label = "GoFarmApp", Icon = "@mipmap/Farmacia72", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}
