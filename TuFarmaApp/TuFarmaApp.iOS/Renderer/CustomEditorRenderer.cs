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

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace TuFarmaApp.iOS.Renderer
{
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {

            base.OnElementChanged(e);
            if (Control != null)
            {

                //Control.BorderStyle = UITextBorderStyle.None;
                //Control.Layer.CornerRadius = 10;
                //Control.TextColor = UIColor.White;
            }
        }
    }
}