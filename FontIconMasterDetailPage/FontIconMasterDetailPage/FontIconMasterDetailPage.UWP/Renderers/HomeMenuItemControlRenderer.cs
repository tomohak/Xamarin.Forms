using FontIconMasterDetailPage.Controls;
using FontIconMasterDetailPage.UWP.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(HomeMenuItemControl), typeof(HomeMenuItemControlRenderer))]
namespace FontIconMasterDetailPage.UWP.Renderers
{
    public class HomeMenuItemControlRenderer : ViewCellRenderer
    {
        public override Windows.UI.Xaml.DataTemplate GetTemplate(Cell cell)
        {
            return App.Current.Resources["HomeMenuItemTemplate"] as Windows.UI.Xaml.DataTemplate;
        }
    }
}
