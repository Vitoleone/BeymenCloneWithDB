using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.ViewModels.Base;
using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using eShopOnContainers.Core.Models.Search;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace eShopOnContainers.Core.Views
{
    
    public partial class SearchView : ContentPageBase
    {
        public ObservableCollection<ProductModel> products;
        public ObservableCollection<UrunModel> urunler;
        ObservableCollection<ProductModel> removedItems = new ObservableCollection<ProductModel>();
        private readonly ProductModel[] sourceItems =
            {
                new ProductModel{Name ="KADIN", Image="Kadin",
                },
                new ProductModel{Name ="ERKEK", Image="erkek_cleanup",
                }
            };
        public SearchView()
        {
            
            InitializeComponent();
            products = new ObservableCollection<ProductModel>(sourceItems);
            myCollectionView.ItemsSource = products;
        }
        public void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue.ToUpper();


            foreach (ProductModel sourceItem in sourceItems)
            {
                if (!sourceItem.Name.StartsWith(searchTerm) && !removedItems.Contains(sourceItem))
                {

                    removedItems.Add(sourceItem);

                    products.Remove(sourceItem);
                }

            }
            if (removedItems.Count > 0)
            {
                foreach (ProductModel removedItem in removedItems.ToList())
                {
                    if (removedItem.Name.StartsWith(searchTerm) || string.IsNullOrWhiteSpace(searchTerm))
                    {
                        products.Add(removedItem);
                        removedItems.Remove(removedItem);
                        if (removedItems.Count == 0)
                        {
                            break;
                        }
                    }

                }
            }


        }


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Anasayfa());
        }

        private void Kadin(object sender, SelectionChangedEventArgs e)
        {
            var b = e.CurrentSelection.FirstOrDefault() as ProductModel;


            if (b.Name == "KADIN")
            {
                Navigation.PushAsync(new Anasayfa());

            }
            else if (b.Name == "ERKEK")
            {
                Navigation.PushAsync(new Anasayfa());

            }
        }
    }
}