using coronoless.uygulama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coronoless
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void birinci_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new vki());
        }

        private async void İkinci_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new bazalmetobo());
        }

        private async void Üçüncü_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new belcevresi());
        }

        private async void beşinci_Clicked(object sender, EventArgs e)
        {
           
        }

        private async void belkalca_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new belkalcaoranı());
        }

        private async void idaelkilo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new idealkilohesabı());
        }

        private async void vyuzeyalan_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new vucutyuzeyalanı());
        }

        private async void toplamsu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new toplamsumik());
        }
    }
}