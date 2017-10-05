using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CoolBreeze.CustomRenderer;
using CoolBreeze.Droid.CustomButton_Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButton_Android))]
namespace CoolBreeze.Droid.CustomButton_Android
{
    using Android.Graphics.Drawables;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    public class CustomButton_Android : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control == null) return;

            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid(Color.Aquamarine));
            gradientDrawable.SetStroke(4,Element.BorderColor.ToAndroid());
            gradientDrawable.SetCornerRadius(30.0f);

            Control.SetBackground(gradientDrawable);
        }

}
}