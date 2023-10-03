using Android.Content;
using Taskmanager.Mobile.Controls;
using Taskmanager.Mobile.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(InputTextEditRenderer))]
namespace Taskmanager.Mobile.Droid.Renderers
{
    public class InputTextEditRenderer : EntryRenderer
    {
        public InputTextEditRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if ( e.OldElement == null )
                Control.Background = null;
        }
    }
}