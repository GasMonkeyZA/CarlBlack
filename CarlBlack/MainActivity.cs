using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace CarlBlack
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {

        Button ButtonNext;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            ButtonNext = FindViewById<Button>(Resource.Id.btnNext);

            this.FindViewById<Button>(Resource.Id.btnNext).Click += btnNext_Click;
        }

            private void btnNext_Click(object sender, EventArgs e)
            {
                Intent intMain = new Intent(this, typeof(CarlBlack.Next));
                StartActivity(intMain);
            }

        }
    }
