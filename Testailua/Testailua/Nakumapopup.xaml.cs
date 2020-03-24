using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testailua
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nakumapopup : PopupPage
    {
        public Nakumapopup()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void Button_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new Tokapopup());
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        [Obsolete]
        private void SwipedLeft(object sender, SwipedEventArgs e)
        {
            PopupNavigation.RemovePageAsync(this);
            PopupNavigation.PushAsync(new Tokapopup());
        }
    }
}