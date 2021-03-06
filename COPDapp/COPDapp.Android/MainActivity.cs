﻿using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace COPDapp.Droid
{
    [Activity(Label = "COPDapp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            Xamarin.Forms.MessagingCenter.Subscribe<EducationVideo>(this, "OnlyLandscape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Landscape;
            });

            Xamarin.Forms.MessagingCenter.Subscribe<EducationVideo>(this, "Unspecified", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
                RequestedOrientation = ScreenOrientation.Unspecified;
            });

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}