using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using SaglikApp.CustomControls;
using SaglikApp.Droid.Renders;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace SaglikApp.Droid.Renders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        #region Constructor
        public CustomEntryRenderer(Context context) : base(context)
        {

        }
        #endregion

        #region Overrides Methods
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                // Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            }
        }
        #endregion
    }
}