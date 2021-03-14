using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace coronoless.uygulama
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class vki : ContentPage
    {
        public vki()
        {
            InitializeComponent();
        }
        double m;
        double kg;
        bool tamammı;
        bool kabulmu;
        double hesapla = 0;
        private void Hesaplabutton_Clicked(object sender, EventArgs e)
        {
            uyarılabel.Text = null;
            sonuç.Text = null;
            if (entrybirinci.Text == null || entryikinci.Text == null)
            {
                sonuç.Text = "PLEASE DO NOT LEAVE BLANK";
            }
            else
            {
                tamammı = true;
                kabulmu = true;
                char[] ara1 = entryikinci.Text.ToCharArray();
                for (int i = 0; i < ara1.Length; i++)
                {
                    if (ara1[i] == '.' || ara1[i] == ',')
                    {
                        sonuç.Text = "Should be in cm";
                        tamammı = false;
                        break;

                    }
                    else
                    {
                        tamammı = true;
                        m = Convert.ToDouble(entryikinci.Text);
                    }

                }
                char[] ara2 = entrybirinci.Text.ToCharArray();
                for (int i = 0; i < ara2.Length; i++)
                {
                    if (ara2[i] == '.' || ara2[i] == ',')
                    {
                        sonuç.Text = "Should be in kg";

                        kabulmu = false;
                        break;
                    }
                    else
                    {
                        kg = Convert.ToDouble(entrybirinci.Text);
                        kabulmu = true;

                    }
                }
                if (tamammı == true && kabulmu == true)
                {
                    m = m * m;
                    double yeni = m / 10000;
                    hesapla = kg / yeni;

                    string a1 = Convert.ToString(hesapla);
                    string a2 = a1.Remove(5);

                    string bak = "your body mass index=" + a2 + "BMI";
                    if (hesapla <= 18.49)
                        sonuç.Text = "below ideal weight" + bak;
                    else if (hesapla >= 18.50 && hesapla <= 24.99)
                        sonuç.Text = "Ideal weight " + bak;
                    else if (hesapla >= 25 && hesapla <= 29.99)
                        sonuç.Text = "above ideal weight " + bak;
                    else
                        sonuç.Text = "well above ideal weight" + bak;
                }
            }

         
            entrybirinci.Text = null;
            entryikinci.Text = null;
            
        }
    }
}