using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using eShopOnContainers.Droid.Activities;
using eShopOnContainers.Droid.Services;
using Firebase;
using System;
using Xamarin.Forms.Platform.Android;

namespace eShopOnContainers.Droid
{
    [Activity(Label = "FirebaseAuth", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Xamarin.Forms.DependencyService.Register<FirebaseAuthentication>();
            //FirebaseApp.InitializeApp(Application.Context);
            var options = new FirebaseOptions.Builder()
            .SetApplicationId("beymen - 41561")
            .SetApiKey("AIzaSyDljeRsnrxwjtyNSspE6QlCVnAGLUpM8vI")
            .SetStorageBucket("beymen-41561.appspot.com").Build();
            var fapp = FirebaseApp.InitializeApp(this, options);

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

