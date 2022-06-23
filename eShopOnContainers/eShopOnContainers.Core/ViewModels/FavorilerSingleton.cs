

using eShopOnContainers.Core.Models.Search;
using System.Collections.ObjectModel;

namespace eShopOnContainers.Core.ViewModels
{
    public class FavorilerSingleton
    {
        public static readonly FavorilerSingleton instance = new FavorilerSingleton();


        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        int index = -1;
        public UrunModel yeniUrun = new UrunModel();
        public ObservableCollection<UrunModel> favoriUrunler = new ObservableCollection<UrunModel>();
        public int urunSayisi;
        static FavorilerSingleton()
        {

        }



        public static FavorilerSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void FavoriEkle(string Name, string Image, string Discount, string Price, string DiscountedPrice, string BedenPicker, string RenkPicker)
        {



            yeniUrun.Name = Name;
            yeniUrun.Image = Image;
            yeniUrun.Discount = Discount;
            yeniUrun.Price = Price;
            yeniUrun.DiscountedPrice = DiscountedPrice;
            yeniUrun.BedenPicker = BedenPicker;
            yeniUrun.RenkPicker = RenkPicker;

            index++;
            favoriUrunler.Add(yeniUrun);
            urunSayisi++;






        }
        public void sil(UrunModel urun)
        {
            favoriUrunler.Remove(urun);
        }



    }
}
