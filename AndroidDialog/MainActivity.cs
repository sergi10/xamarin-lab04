using Android.App;
using Android.Widget;
using Android.OS;
using PCLProject;

namespace AndroidDialog
{
    [Activity(Label = "AndroidDialog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var Validator = new AppValidator(new AdroidDialog(this));

            Validator.EMail = "email at domain dot net";
            Validator.Password = "PassWord";
            Validator.Device = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            Validator.Validate();
        }
    }
}

