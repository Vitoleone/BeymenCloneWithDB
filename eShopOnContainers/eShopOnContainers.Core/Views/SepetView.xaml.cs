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
    public partial class SepetView : ContentPageBase
    {
        public ObservableCollection<UrunModel> sepetUrunler;
        public UrunModel yeniUrun;
        public ObservableCollection<UrunModel> urunler;
        public SepetView()
        {
            InitializeComponent();
            BindingContext = this;
            urunler = new ObservableCollection<UrunModel>(SepetSingleton.Instance.sepetUrunler);
            sepetimUrunler.ItemsSource = SepetSingleton.Instance.sepetUrunler;
           if(SepetSingleton.instance.urunSayisi <= 0)
            {
                SepetSatinalButon.IsVisible = false;
            }
           else
            {
                SepetSatinalButon.IsVisible = true;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Xamarin.Forms.Button;
            var vm = button.BindingContext as UrunModel;
            SepetSingleton.Instance.sil(vm);

        }
    }
}