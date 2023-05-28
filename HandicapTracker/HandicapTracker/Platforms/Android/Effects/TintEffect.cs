﻿using Android.Graphics;
using Android.Widget;
using HandicapTracker.Effects;
using HandicapTracker.Platforms.Android.Effects;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using System.ComponentModel;

[assembly: ResolutionGroupName("HandicapTracker")]
[assembly: ExportEffect(typeof(TintColorEffect), nameof(TintEffect))]

namespace HandicapTracker.Platforms.Android.Effects
{
    public class TintColorEffect : PlatformEffect
    {
        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == TintEffect.TintColorProperty.PropertyName)
            {
                UpdateColor();
            }
        }

        protected override void OnAttached()
        {
            UpdateColor();
        }

        protected override void OnDetached()
        {
        }

        void UpdateColor()
        {
            try
            {
                var color = TintEffect.GetTintColor(Element);
                var filter = new PorterDuffColorFilter(color.ToAndroid(), PorterDuff.Mode.SrcIn);
                if (Control is ImageView imageView)
                {
                    imageView.SetColorFilter(filter);
                }
            }
            catch
            {
                //do nothing
            }
        }
    }
}