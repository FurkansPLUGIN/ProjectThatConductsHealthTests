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
    public partial class toplamsumik : ContentPage
    {
        public toplamsumik()
        {
            InitializeComponent();
            var cinsiyet = new List<string>();
            cinsiyet.Add("WOMAN");
            cinsiyet.Add("MAN");
            cin.ItemsSource = cinsiyet;
            
            var yaslist = new List<int>();
            for (int i = 10; i < 80; i++)
                yaslist.Add(i);
            yas.ItemsSource = yaslist;

            var kilom = new List<int>();
            for (int i = 45; i < 250; i++)
                kilom.Add(i);
            kılo.ItemsSource = kilom;


            var boyum = new List<int>();
            for (int i = 45; i < 250; i++)
                boyum.Add(i);
            boy.ItemsSource = boyum;

        }

        private void cin_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void hesap_Clicked(object sender, EventArgs e)
        {
            double islema = 0;
            //Kadınlar İçin:      Toplam Vücut Suyu = -2,097 + 0,2466 x kilo(kg) + 0,1069 x boy(cm)

            // Erkekler İçin:      Toplam Vücut Suyu = 2,447 + 0,3362 x kilo(kg) +0,1074 x boy(cm) -0,09156 x yaş

            double yasici = Convert.ToDouble(yas.SelectedItem);
            double kiloıcı = Convert.ToDouble(kılo.SelectedItem);
            double boyıcı = Convert.ToDouble(boy.SelectedItem);

            if (cin.SelectedIndex == 0)
            {
                islema = -2.097 + 0.2466 * kiloıcı + 0.1069 * boyıcı;
                string a1 = Convert.ToString(islema);
                string a2 = a1.Remove(5);
                son.Text = "Your total amount of water=" + a2;
            }
           if(cin.SelectedIndex==1)
            {
                islema = 2.447 + 0.3362 * kiloıcı + 0.1074 * boyıcı - 0.09156 * yasici;
                string a1 = Convert.ToString(islema);
                string a2 = a1.Remove(5);
                son.Text = "Your total amount of water= " + a2;
            }
           
        }
    }
}