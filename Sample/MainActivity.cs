using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Threading.Tasks;

namespace Sample
{
    [Activity(Label = "LoaderView", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            loadData();
        }

        private void loadData()
        {
            Task.Delay(3000).ContinueWith((arg) => postLoadData());
        }

        private void postLoadData()
        {
            RunOnUiThread(() =>
            {
                FindViewById<TextView>(Resource.Id.txt_name).Text = "Mr. Donald Trump";
                FindViewById<TextView>(Resource.Id.txt_title).Text = "Presidency Candidate of United State";
                FindViewById<TextView>(Resource.Id.txt_phone).Text = "+001 2345 6789";
                FindViewById<TextView>(Resource.Id.txt_email).Text = "donald.trump@donaldtrump.com";
                FindViewById<ImageView>(Resource.Id.image_icon).SetImageResource(Resource.Drawable.trump);
            });
        }
    }
}


