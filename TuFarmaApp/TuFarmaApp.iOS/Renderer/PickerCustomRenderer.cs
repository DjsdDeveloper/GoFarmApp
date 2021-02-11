using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(PickerCustom), target: typeof(PickerCustomRenderer))]
namespace TuFarmaApp.iOS.Renderer
{
    public class PickerCustomRenderer : PickerRenderer
    {

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
                var imgDropDownArrow = UIImage.FromFile("ddarrow.png");
                Control.RightViewMode = UITextFieldViewMode.Always;
                Control.RightView = new UIImageView(imgDropDownArrow);
            }
        }
    }
}