using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phoneword
{
    [Activity(Label = "@string/aboutAuthor")]
    public class AboutAuthorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.aboutAuthor);

            TextView authorInfo = FindViewById<TextView>(Resource.Id.authorInfo);
            ImageView photo = FindViewById<ImageView>(Resource.Id.photo);
            Button backButton = FindViewById<Button>(Resource.Id.backButton);

            backButton.Click += (sender, e) =>
            {
                this.Finish();
            };
        }
    }
}