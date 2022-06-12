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
    public partial class ErkekKategoriView : ContentPageBase
    {
        public ErkekKategoriView()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void ErkekSaat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());

        }

        private void ErkekGiyim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
        private void ErkekAyakkabi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }
    }
}