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
    public partial class ArvosteluSivu0 : ContentPage
    {
        private int _sivu = 0;
        public ArvosteluSivu0()
        {
            InitializeComponent();
            Skroll.ScrollToAsync(0, _sivu, true);
        }

        private void EDELLINEN(object sender, EventArgs e)
        {
            if (_sivu != 0)
            {
                _sivu -= 500;
                Skroll.ScrollToAsync(0, _sivu, true);

            }
        }

        private void SEURAAVA(object sender, EventArgs e)
        {
            _sivu += 500;

            if (_sivu < 1500)
            {
                Skroll.ScrollToAsync(0, _sivu, true);

            }
            if (_sivu == 1500)
            {

                Navigation.PushModalAsync(new ArvosteluSivu1());
                _sivu -= 500;
            }
        }
    }
}