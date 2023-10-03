using Taskmanager.Mobile.Controls;
using Taskmanager.Mobile.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(InputTextEditRenderer))]
namespace Taskmanager.Mobile.iOS.Renderers
{
    public class InputTextEditRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if ( Control != null )
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
        }
    }
}