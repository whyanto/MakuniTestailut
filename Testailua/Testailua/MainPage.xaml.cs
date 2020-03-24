using Rg.Plugins.Popup.Services;
using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace Testailua
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int _sivu = 0;
        public MainPage()
        {
            InitializeComponent();
            Skroll.ScrollToAsync(0, _sivu, true);
        }

        private void EDELLINEN(object sender, EventArgs e)
        {
            if(_sivu != 0) 
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
