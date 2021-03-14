using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace coronoless.uygulama
{
   public class girişsy:ContentPage
    {
        Image splashımage;
        public girişsy()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashımage = new Image
            {
                Source = "https://cdn.pixabay.com/photo/2020/04/01/05/52/corona-4990008_960_720.png",

                WidthRequest = 400,
                HeightRequest = 400

            };
            AbsoluteLayout.SetLayoutFlags(splashımage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashımage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashımage);
            this.BackgroundColor = Color.White;
            this.Content = sub;
            //var text = new Label
            //{
            //    Text = "Bu zor zamanlarda malesefki vücut sağlığımızı istediğimiz gibi koruyamadık. Biz de kendimize biraz daha " +
            //    "dikkat etmeyi sağlamak için bu uygulamayı oluşturduk. Sağlıklı günler Unutmayın sağlık herşerydir",
            //    TranslationY = 150

            //};
            //this.Content = text;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(4000);
            NavigationPage navigation = new NavigationPage(new Page1())
            {
                BackgroundColor = Color.FromHex("#003a67"),
                
                 BarTextColor = Color.White
                
            };
            Application.Current.MainPage = navigation;
        }
    }
}
