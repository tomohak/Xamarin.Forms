using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FontIconMasterDetailPage.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeMenuItemControl : ViewCell
	{
		public HomeMenuItemControl ()
		{
			InitializeComponent ();
		}

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create("Title", typeof(string), typeof(HomeMenuItemControl), "Title");

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create("Icon", typeof(FileImageSource), typeof(HomeMenuItemControl), null);

        public FileImageSource Icon
        {
            get { return (FileImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }
}