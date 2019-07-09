using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using AngelaAPPa.Droid.Modelo;
using AngelaAPPa.Droid.AccesoDatos;
using AngelaAPPa.Droid.Adaptadores;
using Android.Content;

namespace AngelaAPPa.Droid
{
    [Activity(Label = "AngelaAPPa", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {


            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainMenu);

            var btnClientes = FindViewById<Button>(Resource.Id.btnCLiente);
            var btnVenta= FindViewById<Button>(Resource.Id.btnVenta);


            btnClientes.Click += delegate {

                StartActivity(typeof(ActivityCliente));
            };

        }
    }
}
