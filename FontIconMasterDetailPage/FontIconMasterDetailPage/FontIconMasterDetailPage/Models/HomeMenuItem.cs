using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FontIconMasterDetailPage.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public FileImageSource Icon { get; set; }
    }
}
