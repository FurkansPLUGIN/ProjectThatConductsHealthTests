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
    public partial class idealkilohesabı : ContentPage
    {
        public idealkilohesabı()
        {
            InitializeComponent();
            var cinsiyet = new List<string>();
            cinsiyet.Add("MAN");
            cinsiyet.Add("WOMAN");
            cin.ItemsSource = cinsiyet;

            //var kglist = new List<int>();
            //for (int i = 45; i < 191; i++)
            //    kglist.Add(i);
            //kg.ItemsSource = kglist;

            var cmlist = new List<int>();
            for (int i = 45; i < 250; i++)
                cmlist.Add(i);
            boy.ItemsSource = cmlist;
        }

        private void cin_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void hesap_Clicked(object sender, EventArgs e)
        {
           // Kadınlar İçin:      İdeal Kilo = 45,5 + (2, 3 / 2, 54) x(boy(cm) - 152, 4)

           // Erkekler İçin:      İdeal Kilo = 50 + (2, 3 / 2, 54) x(boy(cm) - 152, 4)    
            //double kgiçin = Convert.ToDouble(kg.SelectedItem);
            double cmiçin = Convert.ToDouble(boy.SelectedItem);
            double sonhesap = 0;
            if (cin.SelectedIndex == 0)
            {
                sonhesap = 50 + (2.3 / 2.54) * (cmiçin - 152.4);
                string a1 = Convert.ToString(sonhesap);
                string a2 = a1.Remove(5);
                son.Text = "Your ideal weight= "+ a2;
            }
           if(cin.SelectedIndex==1)
            {
                sonhesap = 45.5 + (2.3 / 2.54) * (cmiçin - 152.4);
                string a1 = Convert.ToString(sonhesap);
                string a2 = a1.Remove(5);
                son.Text = "Your ideal weight= " + a2;
            }
        }
    }
}