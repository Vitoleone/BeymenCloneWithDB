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
using eShopOnContainers.Core.ViewModels;

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
        void SepeteEkle(object sender, EventArgs e)
        {
            if (renkPicker.SelectedItem != null && bedenPicker.SelectedItem != null)
            {
                string renk = renkPicker.SelectedItem.ToString();
                string beden = bedenPicker.SelectedItem.ToString();

                DisplayAlert("", "Ürün sepetinize eklendi!", "Tamam");
                ürünSayisi++;
                SepetSingleton.Instance.SepeteEkle(urunler.Name, urunler.Image, urunler.DiscountedPrice, urunler.Price, urunler.Discount, beden, renk);

            }
            else
            {
                DisplayAlert("", "Lütfen renk ve beden seçiniz!", "Tamam");

            }

        }
        void FavoriEkle(object sender, EventArgs e)
        {
            if (renkPicker.SelectedItem != null && bedenPicker.SelectedItem != null)
            {
                string renk = renkPicker.SelectedItem.ToString();
                string beden = bedenPicker.SelectedItem.ToString();

                DisplayAlert("", "Ürün favorilerinize eklendi!", "Tamam");
                ürünSayisi++;
                FavorilerSingleton.Instance.FavoriEkle(urunler.Name, urunler.Image, urunler.DiscountedPrice, urunler.Price, urunler.Discount, beden, renk);

            }
            else
            {
                DisplayAlert("", "Lütfen renk ve beden seçiniz!", "Tamam");

            }

        }
    }
}