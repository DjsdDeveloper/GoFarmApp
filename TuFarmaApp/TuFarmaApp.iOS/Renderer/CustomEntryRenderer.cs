using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuFarmaApp.CustomRender;
using TuFarmaApp.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(MyEntryRenderer))]
namespace TuFarmaApp.iOS.Renderer
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var element = (CustomEntry)Element;
                if (element.HasBorder)
                {
                    Control.BorderStyle = UITextBorderStyle.Line;
                    Control.Layer.BorderColor = element.BorderColor.ToCGColor();
                    Control.Layer.BorderWidth = 4;
                }

                if (element.HasIcon)
                {
                    var imageView = new UIImageView();
                    var imageEmail = UIImage.FromFile("lupa.png");
                    imageView.Image = imageEmail;

                    // set frame on image before adding it to the uitextfield
                    imageView.Frame = new CoreGraphics.CGRect(x: 5, y: 5, width: 20, height: 20);
                    Control.LeftViewMode = UITextFieldViewMode.Always;
                    Control.Add(imageView);

                    //set Padding
                    var paddingView = new UIView();
                    paddingView.Frame = new CoreGraphics.CGRect(0, 0, 25, Control.Frame.Height);
                    Control.LeftView = paddingView;
                }
            }
        }
    }
}