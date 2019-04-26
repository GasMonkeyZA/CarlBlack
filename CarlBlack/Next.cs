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

namespace CarlBlack
{
    [Activity(Label = "Next")]
    public class Next : Activity
    {
        Button btn1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // set our view from the "second" layout resource
            SetContentView(Resource.Layout.layout_2);

           /* //Creates a "Pop-Up" to show that this activity has now opened
            AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle("Alert");
            alert.SetMessage("Next opened");
            alert.SetButton("OK", (c, ev) =>
            {
                //
            });
            alert.Show();*/

            btn1 = FindViewById<Button>(Resource.Id.btn1);

            this.FindViewById<Button>(Resource.Id.btn1).Click += btn1_Click;

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Intent actMain = new Intent(this, typeof(MainActivity));
            StartActivity(actMain);
        }
    }
}