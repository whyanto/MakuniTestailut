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
    public partial class ArvosteluSivu2 : ContentPage
    {
        private int _sivu = 0;
        public ArvosteluSivu2()
        {
            InitializeComponent();
            Skroll.ScrollToAsync(0, _sivu, true);
        }
        private void EDELLINEN(object sender, EventArgs e)
        {
            if (_sivu == 0)
            {
                Navigation.PopModalAsync();
            }
            if (_sivu != 0)
            {
                _sivu -= 500;
                Skroll.ScrollToAsync(0, _sivu, true);

            }
            
        }

        private void SEURAAVA(object sender, EventArgs e)
        {
            _sivu += 500;

            if (_sivu < 1000)
            {
                Skroll.ScrollToAsync(0, _sivu, true);

            }
            if (_sivu == 1000)
            {
                Navigation.PushModalAsync(new ArvosteluSivu3());
                _sivu -= 500;
            }
        }
    }
}