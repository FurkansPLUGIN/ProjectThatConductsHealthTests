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
    public partial class vücutküylehacim : ContentPage
    {
        public vücutküylehacim()
        {
            InitializeComponent();
        }
        double hesap = 0;
        double hesap1 = 0;
        double hesap2 = 0;
        bool incleme;
        char[] inc;
        char[] inc1;
        bool kabul;
        private void hesapla_Clicked(object sender, EventArgs e)
        {

            if (boy.Text == null || kilo.Text == null)
            {
                uyarı.Text = "Lütfen doğru giriş yapun";
                kabul = false;
            }
            else
            {
                char[] inc = boy.Text.ToCharArray();
                char[] inc1 = kilo.Text.ToCharArray();
                kabul = true;

                for (int i = 0; i < kilo.Text.Length; i++)
                {
                    if (inc1[i] == ',' || inc1[i] == '.')
                    {
                        uyarı.Text = "kg cinsinden girin";
                        incleme = false;
                        break;
                    }
                    else
                    {

                        incleme = true;
                        double kiloo = Convert.ToDouble(kilo.Text);
                        double hesap2 = kiloo * 2.2046;
                    }
                }
                for (int i = 0; i < boy.Text.Length; i++)
                {
                    if (inc[i] == ',' || inc[i] == '.')
                    {
                        uyarı.Text = "boyunuzu cm cinsinden girin";
                        incleme = false;
                        break;
                    }
                    else
                    {

                        incleme = true;
                        double booy = Convert.ToDouble(boy.Text);
                        double hesap1 = booy / 2.54;
                    }
                }


            }

            cinsiyet.Text.ToLower();
            if (kabul == true)
            {
                if (cinsiyet.Text == "xx" && incleme == true)
                {
                    //(0.006012 x Boy3) + (14.6 x Kilo) + 604 = Kan Hacmi (mL)
                    //1 santimetrenin 2.54 inç olduğunu ve 1 kilogramın da 2.2046 pounda tekabül ettiğini bilmeniz gerek.
                    //Boyunuzu inç cinsinden hesapladıktan sonra küpünü alarak 0.006012 sayısıyla çarpın.
                    //Kilonuzu pound cinsinden hesapladıktan sonra 14.6 ile çarpın.
                    hesap = (0.006012 * hesap1 * hesap1 * hesap1) + (hesap2 * 14.6) + 604;
                    uyarı.Text = "vücut kan hacmiminiz: " + hesap;
                }
                else if (cinsiyet.Text == "xy" && incleme == true)
                {
                    //(0.005835 x Boy3) + (15 x Kilo)+183
                    hesap = (0.005835 * hesap1 * hesap1 * hesap1) + (15 * hesap2) + 183;
                    uyarı.Text = "vücut kan hacmiminiz: " + hesap;
                }
                else
                {
                    uyarı.Text = "değerleri doğru girdiğinizden emin olun";
                }
            }
            boy.Text = null;
            kilo.Text = null;
            cinsiyet.Text = null;
        }
    }
}