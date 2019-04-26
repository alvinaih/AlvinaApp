using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AlvinaApp
{
    [Activity(Label = "Layout2")]
    class Layout2: Activity
    {
        Button buttonBack;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "second" layout resource
            SetContentView(Resource.Layout.layout_2);

            buttonBack = FindViewById<Button>(Resource.Id.btnBack);

            this.FindViewById<Button>(Resource.Id.btnBack).Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Intent actMain = new Intent(this, typeof(MainActivity));
            StartActivity(actMain);
        }
    }
}