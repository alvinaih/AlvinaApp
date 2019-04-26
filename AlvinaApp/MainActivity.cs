using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace AlvinaApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Button buttonNext;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            buttonNext = FindViewById<Button>(Resource.Id.btnNext);

            this.FindViewById<Button>(Resource.Id.btnNext).Click += BtnNext_Click;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Intent actMain = new Intent(this, typeof(Layout2));
            StartActivity(actMain);
        }
    }
}