using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testailua
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new KaikkiArvostelusivutYhdessa();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
