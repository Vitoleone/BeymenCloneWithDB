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
    public partial class KadinCantaView : ContentPageBase
    {
        public ObservableCollection<UrunModel> urunler;

        private readonly UrunModel[] urunlerSourceSol =
        {
            new UrunModel{Name="Siyah Kadın Deri Çanta",Image ="kadinCanta1",Discount = "-%50",Price="1.799,00 TL", DiscountedPrice = "899,00 TL"},
            new UrunModel{Name="Monogram Siyah Kadın Deri Tablet Çantası",Image ="kadinCanta2",Discount = "-%30",Price="2.199,00 TL", DiscountedPrice = "1.549,00 TL"},
            new UrunModel{Name="Siyah Zincir Detaylı Kadın Deri Omuz Çantası",Image ="kadinCanta3",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Kadın Spor Çanta",Image ="kadinCanta4",Discount = "-%48",Price="1.799,00 TL", DiscountedPrice = "929,00 TL"},
            new UrunModel{Name="Loulou Toy Siyah Kadın Deri Omuz Çantası",Image ="kadinCanta5",Discount = "-%50",Price="10.750,00 TL", DiscountedPrice = "5.350,00 TL"},

        };
        public KadinCantaView()
        {
            InitializeComponent();

            urunler = new ObservableCollection<UrunModel>(urunlerSourceSol);

            myCollectionView.ItemsSource = urunler;


            BindingContext = this;
        }
        public ICommand GoBackCommand => new Command(execute: () => { Navigation.PushAsync(new KategoriAltSayfasiView()); });
        private void myCollectionView_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var ayakkabiUrun = e.CurrentSelection.FirstOrDefault() as UrunModel;
            Navigation.PushAsync(new KadinUrunSayfasiView(ayakkabiUrun.Name, ayakkabiUrun.Image, ayakkabiUrun.Discount, ayakkabiUrun.Price, ayakkabiUrun.DiscountedPrice));
        }
    }
}