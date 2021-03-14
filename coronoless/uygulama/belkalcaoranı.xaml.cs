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
    public partial class belkalcaoranı : ContentPage
    {
        double belekle = 0.1;
        double kalekle = 0.1;
        public belkalcaoranı()
        {
            InitializeComponent();
            var cinsiyetlist = new List<string>();
            cinsiyetlist.Add("MAN");
            cinsiyetlist.Add("WOMEN");
            cinsiyet.ItemsSource = cinsiyetlist;
            double dd = 150;
            double aa = 0.1;
            int bozulma = 80;
            var belcevrelist = new List<string>();
            for (int i = 0; i < 700; i++)
            {
                dd = dd - aa;
                if (aa >= 1)
                    aa = 0.1;
                string a1 = Convert.ToString(dd);
                string a2 = a1.Substring(0,5);


                belcevrelist.Add(a2);
            }
               
               
            belcevre.ItemsSource = belcevrelist;

            double ff = 200;
            double cc = 0.1;
            var kalcacevrelist = new List<double>();
            for (int i = 0; i < 400; i++)
            {
                ff = ff - cc;
                if (cc == 1)
                    cc = 0.1;
                if (i == bozulma)
                    ff = 192;
                if (i == bozulma * 2)
                    ff = 184;
                if (i == bozulma * 3)
                    ff = 176;
                kalcacevrelist.Add(ff);
            }
                

            kalcacevre.ItemsSource = kalcacevrelist;
        }

        private void cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        double hesapla = 0;
        private void hesap_Clicked(object sender, EventArgs e)
        {
            double belcevrecevir = Convert.ToDouble(belcevre.SelectedItem);
            double kalcevrecevir = Convert.ToDouble(kalcacevre.SelectedItem);
            hesapla = belcevrecevir / kalcevrecevir;
            string a1 = Convert.ToString(hesapla);
            string a2 = a1.Remove(5);
            sonuç.Text = a2;

            //0,80 ve altı: Düşük düzeyde sağlık riski
            //0,81 - 0,84: Orta düzeyde sağlık riski
            //0,85 ve üstü: Yüksek düzeyde sağlık riski

            if (cinsiyet.SelectedIndex== 1)
            {
                if (hesapla <= 0.80)
                {
                    bilgilendirme.Text = "0,80 ve altı: Düşük düzeyde sağlık riski";
                }
                else if (hesapla > 0.81 && hesapla <= 0.84)
                {
                    bilgilendirme.Text = "0,81 - 0,84: Orta düzeyde sağlık riski";
                }
                else
                {
                    bilgilendirme.Text = "0,85 ve üstü: Yüksek düzeyde sağlık riski";
                }

            }
            //0,95 ve altı: Düşük düzeyde sağlık riski
            //0,96 - 1,0: Orta düzeyde sağlık riski
            //1,01 ve üstü: Yüksek düzeyde sağlık riski
            if (cinsiyet.SelectedIndex == 0)
            {
                if (hesapla<=0.95)
                {
                    bilgilendirme.Text = "0,95 ve altı: Düşük düzeyde sağlık riski";
                }
                else if (hesapla>0.95 && hesapla<=1)
                {
                    bilgilendirme.Text = "0,96 - 1,0: Orta düzeyde sağlık riski";
                }
                else
                {
                    bilgilendirme.Text = "1,01 ve üstü: Yüksek düzeyde sağlık riski";
                }
            }
        }
    }
}