using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.Models.Search;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KadinUrunSayfasiView : ContentPageBase
    {
        public UrunModel urunler;
        int ürünSayisi = 0;
        public KadinUrunSayfasiView(string Name, string Image, string Discount, string Price, string DiscountedPrice)
        {
            InitializeComponent();
            BindingContext = this;
            urunler = new UrunModel() { Name = Name, Image = Image, Discount = Discount, Price = Price, DiscountedPrice = DiscountedPrice };
            urunIndirimlbl.Text = Discount;
            urunIndirimlilbl.Text = DiscountedPrice;
            urunIsimlbl.Text = Name;
            urunResmi.Source = Image;
            urunIndirimsizlbl.Text = Price;

        }
        //public ICommand GoBackCommand => new Command(execute: () => { Navigation.PopAsync(); });
        public ICommand GoBackCommand => new Command(execute: () => { Navigation.RemovePage(this);});
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}