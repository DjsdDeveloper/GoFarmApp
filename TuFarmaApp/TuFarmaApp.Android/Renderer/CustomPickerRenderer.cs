using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TuFarmaApp.Droid.Renderer;
using TuFarmaApp.CustomRender;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PickerCustom), typeof(CustomPickerRenderer))]
namespace TuFarmaApp.Droid.Renderer
{
    public class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            SetControlStyle();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetControlStyle();
        }
        private void SetControlStyle()
        {
            if (Control != null)
            {
                Drawable imgDropDownArrow = Resources.GetDrawable(Resource.Drawable.ddarrow);
                imgDropDownArrow.SetBounds(5, 5, 5, 5);
                Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(null, null, imgDropDownArrow, null);

                GradientDrawable gd = new GradientDrawable();
                gd.SetStroke(0, Android.Graphics.Color.Transparent);
                Control.SetBackgroundDrawable(gd);
            }
        }
    }
}