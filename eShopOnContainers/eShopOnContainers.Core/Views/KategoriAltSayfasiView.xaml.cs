using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategoriAltSayfasiView : ContentPageBase
    {
        public KategoriAltSayfasiView()
        {
            InitializeComponent();

            NavigationPage.SetIconColor(this, Color.FromHex("#FFFFFF"));

            
            BindingContext = this;
        }
        private void KadinAksesuar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());

        }

        private void KadinGiyim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
        private void KadinAyakkabi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
        private void KadinCanta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
    }
}