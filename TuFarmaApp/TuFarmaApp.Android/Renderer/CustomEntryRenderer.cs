using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace TuFarmaApp.Droid.Renderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        CustomEntry element;
        public CustomEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                element = (CustomEntry)this.Element;

                var gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);

                if (element.HasBorder)
                {
                    gd.SetStroke(5, element.BorderColor.ToAndroid());
                }

                Control.Background = gd;

                if (element.HasIcon)
                {
                    //GradientDrawable gd = new GradientDrawable();
                    //gd.SetColor(global::Android.Graphics.Color.White);
                    this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                    Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Gray));

                    Control.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable("lupa"), null, null, null);
                }
            }
        }

        public float DpToPixels(float valueInDp)
        {
            Android.Util.DisplayMetrics metrics = Context.Resources.DisplayMetrics;
            return Android.Util.TypedValue.ApplyDimension(Android.Util.ComplexUnitType.Dip, valueInDp, metrics);
        }

        private BitmapDrawable GetDrawable(string imageEntryImage)
        {
            int resID = Context.Resources.GetIdentifier(
                        imageEntryImage,
                        "drawable",
                        Context.PackageName);

            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            //return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));
            return new BitmapDrawable(Resources,
                Bitmap.CreateScaledBitmap(bitmap,
                (int)DpToPixels((float)element.HeightRequest - 17),
                (int)DpToPixels((float)element.HeightRequest - 17),
                //40 * 2, 
                //40 * 2, 
                true));
        }
    }
}