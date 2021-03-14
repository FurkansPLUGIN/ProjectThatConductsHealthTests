using coronoless.uygulama;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coronoless
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new girişsy();
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
