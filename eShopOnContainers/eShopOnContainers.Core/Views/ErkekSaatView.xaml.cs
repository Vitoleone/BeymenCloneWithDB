﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eShopOnContainers.Core.Models.Search;
using System.Collections.ObjectModel;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErkekSaatView : ContentPageBase
    {
        public ObservableCollection<UrunModel> urunler;
        private readonly UrunModel[] urunlerSourceSol =
        {
            new UrunModel{Name="Summit Lite Gri Erkek Kol Saati",Image ="saat1",Discount = "-%50",Price="1.799,00 TL", DiscountedPrice = "899,00 TL"},
            new UrunModel{Name="Siyah Unisex Akıllı Saat",Image ="saat2",Discount = "-%30",Price="2.199,00 TL", DiscountedPrice = "1.549,00 TL"},
            new UrunModel{Name="Superocean Heritage B20 Automatic 46 Saat",Image ="saat3",Discount = "-%42",Price="1.799,00 TL", DiscountedPrice = "1.049,00 TL"},
            new UrunModel{Name="Formula 1 Kol Saati",Image ="saat4",Discount = "-%48",Price="1.799,00 TL", DiscountedPrice = "929,00 TL"},
            new UrunModel{Name="Instruments Kol Saati",Image ="saat5",Discount = "-%50",Price="10.750,00 TL", DiscountedPrice = "5.350,00 TL"},

        };
        public ErkekSaatView()
        {
            urunler = new ObservableCollection<UrunModel>(urunlerSourceSol);

            myCollectionView.ItemsSource = urunler;


            BindingContext = this;
            InitializeComponent();
        }
        private void myCollectionView_SelectionChanged(object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var ayakkabiUrun = e.CurrentSelection.FirstOrDefault() as UrunModel;
            Navigation.PushAsync(new KadinUrunSayfasiView(ayakkabiUrun.Name, ayakkabiUrun.Image, ayakkabiUrun.Discount, ayakkabiUrun.Price, ayakkabiUrun.DiscountedPrice));
        }
    }
}