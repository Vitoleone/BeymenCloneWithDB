using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.Models.Search;
using System.Collections.ObjectModel;
using eShopOnContainers.Services;
using System.Windows.Input;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErkekGiyimView : ContentPageBase
    {
        public ObservableCollection<UrunModel> urunler;
        private readonly UrunModel[] urunlerSourceSol =
        {
            new UrunModel{Name="Slim Fit Siyah Polo Yaka T-shirt",Image ="erkekGiyim1",Discount = "-%50",Price="1.799,00 TL", DiscountedPrice = "899,00 TL"},
            new UrunModel{Name="Beyaz T-shirt",Image ="erkekGiyim2",Discount = "-%30",Price="2.199,00 TL", DiscountedPrice = "1.549,00 TL"},
            new UrunModel{Name="Lacivert Logo Detaylı Kazak",Image ="erkekGiyim3",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Bordo Kapüşonlu Puff Mont",Image ="erkekGiyim4",Discount = "-%48",Price="1.799,00 TL", DiscountedPrice = "929,00 TL"},
            new UrunModel{Name="Lacivert Jogger Eşofman Altı",Image ="erkekGiyim5",Discount = "-%50",Price="10.750,00 TL", DiscountedPrice = "5.350,00 TL"},

        };
        public ErkekGiyimView()
        {
            InitializeComponent();
            urunler = new ObservableCollection<UrunModel>(urunlerSourceSol);

            myCollectionView.ItemsSource = urunler;


            BindingContext = this;
            
        }
        public ICommand GoBackCommand => new Command(execute: () => { Navigation.PushAsync(new ErkekKategoriView()); });
        private void myCollectionView_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var ayakkabiUrun = e.CurrentSelection.FirstOrDefault() as UrunModel;
            Navigation.PushAsync(new KadinUrunSayfasiView(ayakkabiUrun.Name, ayakkabiUrun.Image, ayakkabiUrun.Discount, ayakkabiUrun.Price, ayakkabiUrun.DiscountedPrice));
            
        }
    }
}