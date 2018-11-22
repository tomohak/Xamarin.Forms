using FontIconTabbedPage.UWP.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomTabbedPageRenderer))]
namespace FontIconTabbedPage.UWP.Renderers
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Windows.UI.Xaml.DataTemplate template = App.Current.Resources["TabbedPageHeaderTemplate"] as Windows.UI.Xaml.DataTemplate;
                if (template != null)
                    Control.HeaderTemplate = template;                        
            }

        }
    }
}
