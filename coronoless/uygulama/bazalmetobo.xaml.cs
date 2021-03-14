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
    public partial class bazalmetobo : ContentPage
    {
        public bazalmetobo()
        {
            InitializeComponent();
        }
        double yaşım;
        double kilom;
        double boyum;
        double işlem = 0;
        bool tamammı;
        bool girdi = false;
        char[] ara1;
        char[] ara2;
        char[] ara3;
        bool kabul;
        private void hesapla_Clicked(object sender, EventArgs e)
        {
            if (boy.Text == null || kilo.Text == null || yaş.Text == null)
            {
                sonuç.Text = "PLEASE DO NOT LEAVE BLANK";
                kabul = false;
            }
            else
            {
                ara1 = boy.Text.ToCharArray();
                ara2 = kilo.Text.ToCharArray();
                ara3 = yaş.Text.ToCharArray();
                kabul = true;

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
                        boyum = Convert.ToDouble(boy.Text);
                    }
                }
                for (int i = 0; i < ara2.Length; i++)
                {
                    if (ara2[i] == '.' || ara2[i] == ',')
                    {
                        sonuç.Text = "Should be in kg";
                        tamammı = false;
                        break;

                    }
                    else
                    {
                        tamammı = true;
                        kilom = Convert.ToDouble(kilo.Text);
                    }
                }
                for (int i = 0; i < ara3.Length; i++)
                {
                    if (ara3[i] == '.' || ara3[i] == ',')
                    {
                        sonuç.Text = "Please enter whole number";
                        tamammı = false;
                        break;

                    }
                    else
                    {
                        tamammı = true;
                        yaşım = Convert.ToDouble(yaş.Text);
                    }
                }
                cinsiyet.Text.ToLower();
                if (kabul == true)
                {
                    if (cinsiyet.Text == "xx" && tamammı == true)
                    {
                        işlem = 665 + (9.6 * kilom) + (1.7 * boyum) - (4.7 * yaşım);
                        //string a1 = Convert.ToString(işlem);
                        //string a2 = a1.Remove(6);
                        sonuç.Text = işlem + " Is calories";
                        girdi = true;

                    }
                    else if (cinsiyet.Text == "xy" && tamammı == true)
                    {
                        işlem = 66 + (13.75 * kilom) + (5 * boyum) - (6.8 * yaşım);
                        //string a1 = Convert.ToString(işlem);
                        //string a2 = a1.Remove(6);
                        sonuç.Text = işlem + " Is calories";
                        girdi = true;

                    }
                    else
                    {
                        sonuç.Text = "Make sure you entered values ​​correctly";
                    }
                }
                yaş.Text = null;
                boy.Text = null;
                kilo.Text = null;
                cinsiyet.Text = null;
            }

         
        }
    }
}