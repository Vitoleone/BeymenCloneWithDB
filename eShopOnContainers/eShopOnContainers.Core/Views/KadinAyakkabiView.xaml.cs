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
    public partial class KadinAyakkabiView : ContentPageBase
    {
        public ObservableCollection<UrunModel> urunler;

        private readonly UrunModel[] urunlerSourceSol =
        {
            new UrunModel{Name="Siyah Kadın Deri Bot",Image ="kadinAyakkabi1",Discount = "-%50",Price="1.799,00 TL", DiscountedPrice = "899,00 TL"},
            new UrunModel{Name="Beyaz Kontrast Dikişli Deri Bot",Image ="kadinAyakkabi2",Discount = "-%30",Price="2.199,00 TL", DiscountedPrice = "1.549,00 TL"},
            new UrunModel{Name="Kadın Beyaz Spor Ayakkabı",Image ="kadinAyakkabi3",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Haki Kalın Tabanlı Kadın Deri Bot",Image ="kadinAyakkabi4",Discount = "-%48",Price="1.799,00 TL", DiscountedPrice = "929,00 TL"},
            new UrunModel{Name="Kadın Deri Sneaker",Image ="kadinAyakkabi5",Discount = "-%50",Price="10.750,00 TL", DiscountedPrice = "5.350,00 TL"},

        };
        public KadinAyakkabiView()
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