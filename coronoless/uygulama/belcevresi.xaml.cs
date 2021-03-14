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
    public partial class belcevresi : ContentPage
    {
        public belcevresi()
        {
            InitializeComponent();
        }
        double bel;
        double bel1;
        private void hesap_Clicked(object sender, EventArgs e)
        {
            bool cin = true;
            bool cin1 = true;
            bool dogrula = true;
            if (cm.Text == null && cinsiyet.Text == null)
            {
                yazdıur.Text = "PLEASE DO NOT LEAVE BLANK";
            }
            else
            {
                cinsiyet.Text.ToLower();
                if (cinsiyet.Text == "xx" && cin == true)
                {
                    bel = Convert.ToDouble(cm.Text);
                    cin1 = false;
                }
                else if (cinsiyet.Text == "xy" && cin1 == true)
                {
                    bel1 = Convert.ToDouble(cm.Text);
                    cin = false;
                }
                else yazdıur.Text = "Please enter either xx or xy values";
                char[] aa = cm.Text.ToCharArray();

                for (int i = 0; i < cm.Text.Length; i++)
                {
                    if (aa[i] == '.' || aa[i] == ',' && cin == true)
                    {
                        yazdıur.Text = "It is normal for men to have a waist circumference of less than 94 cm";
                        dogrula = false;
                        break;
                    }
                    if (aa[i] == '.' || aa[i] == ',' && cin1 == true)
                    {
                        yazdıur.Text = "It is normal for women to have waist circumference smaller than 80cm";
                        dogrula = false;
                        break;
                    }
                }
                if (dogrula == true)
                {
                    if (cin1 == true)
                    {
                        if (bel1 <= 94)
                            yazdıur.Text = "(normal) It is normal for men waist circumference less than 94cm";
                        else if ((bel1 >= 95 && bel1 <= 102))
                            yazdıur.Text = "(increased risk) Waist circumference of men greater than 94 cm is risky";
                        else
                            yazdıur.Text = "(high risk) Waist circumference of men greater than 102 cm indicates obesity";
                        cinsiyet.Text = null;
                        cm.Text = null;
                    }

                    if (cin == true)
                    {
                        if (bel <= 80)
                            yazdıur.Text = "(normal) it is normal for women's waist circumference less than 80cm";
                        else if ((bel >= 81 && bel <= 87))
                            yazdıur.Text = "(increased risk) If women have a waistline greater than 80cm, it is risky";
                        else
                            yazdıur.Text = "(high risk) Waist circumference of women greater than 88cm is an indicator of obesity";
                        cinsiyet.Text = null;
                        cm.Text = null;

                    }
                }
                else
                {
                    yazdıur.Text = "operation is invalid";
                }
            }
         
        }
    }
}