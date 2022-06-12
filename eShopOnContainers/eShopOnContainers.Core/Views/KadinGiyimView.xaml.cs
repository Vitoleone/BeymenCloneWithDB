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
    public partial class KadinGiyimView : ContentPageBase
    {
        public ObservableCollection<UrunModel> urunler;
        public ObservableCollection<UrunModel> urunler2;
        private readonly UrunModel[] urunlerSourceSol =
        {
            new UrunModel{Name="Siyah Logolu Pilli Midi Etek",Image ="KadinGiyim1",Discount = "-%30",Price="1.499,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Siyah Desenli Midi Gömlek Elbise",Image ="KadinGiyim2",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Siyah Metal Düğmeli Ribli Triko Ceket",Image ="KadinGiyim3",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Siyah Beyaz Bloklu Mini Elbise",Image ="KadinGiyim4",Discount = "-%30",Price="1.279,00 TL", DiscountedPrice = "899,00 TL"},
            new UrunModel{Name="Camel Kapüşonlu Sweatshirt",Image ="KadinGiyim5",Discount = "-%30",Price="1099,00 TL", DiscountedPrice = "769,00 TL"},

        };
        public KadinGiyimView()
        {
            InitializeComponent();
            urunler = new ObservableCollection<UrunModel>(urunlerSourceSol);

            myCollectionView.ItemsSource = urunler;


            BindingContext = this;
        }
        public ICommand GoBackCommand => new Command(execute: () => {Navigation.PushAsync(new KategoriAltSayfasiView()); });
        private void myCollectionView_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var ayakkabiUrun = e.CurrentSelection.FirstOrDefault() as UrunModel;
            Navigation.PushAsync(new KadinUrunSayfasiView(ayakkabiUrun.Name, ayakkabiUrun.Image, ayakkabiUrun.Discount, ayakkabiUrun.Price, ayakkabiUrun.DiscountedPrice));
        }
    }
}