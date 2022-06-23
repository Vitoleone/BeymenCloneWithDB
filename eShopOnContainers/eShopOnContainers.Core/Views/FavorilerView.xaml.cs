using eShopOnContainers.Core.Models.Search;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavorilerView : ContentPageBase
    {
        public ObservableCollection<UrunModel> favorimUrunler;
        public UrunModel yeniUrun;
        public ObservableCollection<UrunModel> urunler;
        public FavorilerView()
        {
            InitializeComponent();
            BindingContext = this;
            urunler = new ObservableCollection<UrunModel>(FavorilerSingleton.Instance.favoriUrunler);
            favoriUrunler.ItemsSource = FavorilerSingleton.Instance.favoriUrunler;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Xamarin.Forms.Button;
            var vm = button.BindingContext as UrunModel;
            FavorilerSingleton.Instance.sil(vm);

        }
    }
  
}