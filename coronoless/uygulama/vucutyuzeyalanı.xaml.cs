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
    public partial class vucutyuzeyalanı : ContentPage
    {
        public vucutyuzeyalanı()
        {
            string dd = "";
            InitializeComponent();
            var boylist = new List<string>();
            for (int i = 45; i < 250; i++)
            {
                dd = Convert.ToString(i);
                boylist.Add(dd);
            }
               
            boy.ItemsSource = boylist;

            string ff = "";
            var kllist = new List<string>();
            for (int i = 45; i < 250; i++)
            {
                ff = Convert.ToString(i);
                kllist.Add(ff);
            }
               
            kilo.ItemsSource = kllist;
        }

        private void hesap_Clicked(object sender, EventArgs e)
        {
            double boyiçün = Convert.ToDouble(boy.SelectedItem);
            double kiloiçin = Convert.ToDouble(kilo.SelectedItem);
            //Vücut Yüzey Alanı = 0,00718 x(boy(cm) / 100)0,725 x(kilo(kg))0,425 
            //Mosteller Metodu : (Boy x Agirlik / 3600)½
            double hesabı = 0;
             //hesabı = 0.00718 * Math.Pow((boyiçün / 100), 0.725) * Math.Pow((kiloiçin), 0.425);
            //hesabı = Math.Sqrt((boyiçün * kiloiçin) / 3600);
          if(boy.SelectedItem==null || kilo.SelectedItem == null)
            {
               
            }
            else
            {
                hesabı = Math.Pow((boyiçün * kiloiçin) / 3600, 0.5);
                string a1 = Convert.ToString(hesabı);
                string a2 = a1.Remove(5);
                son.Text = "Your surface area=" + a2 + " m2";
            }
        }
    }
}