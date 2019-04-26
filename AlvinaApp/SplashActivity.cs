using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace AlvinaApp
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistableState)
        {
            base.OnCreate(savedInstanceState, persistableState);

            // Create your application here
            SetContentView(Resource.Layout.splash_screen);

            Log.Debug(TAG, "SplashActivity.Oncreate");
        }
        //launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
        }

        async void SimulateStartup()
        {
            Log.Debug(TAG, "Performing some startup work that takes a bit of time");

            // Simulate a bit of a startup work
            await Task.Delay(4000);

            Log.Debug(TAG, "Startup work is finished -start MainActivity or whatever activity is first");

            StartActivity(new Intent(ApplicationContext, typeof(MainActivity)));

        }

    }
}