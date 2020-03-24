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
    public partial class ArvosteluSivu3 : ContentPage
    {
        public ArvosteluSivu3()
        {
            InitializeComponent();
        }
        private void EDELLINEN(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}