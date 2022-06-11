using eShopOnContainers.Core.Models.Basket;
using eShopOnContainers.Core.Models.Catalog;
using eShopOnContainers.Core.Services.Basket;
using eShopOnContainers.Core.Services.Catalog;
using eShopOnContainers.Core.Services.Settings;
using eShopOnContainers.Core.Services.User;
using eShopOnContainers.Core.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AnasayfaViewModel : ViewModelBase
    {
        //Birinci Carousel için resimleri tutacak liste oluşturma
        public class ImageCarouselOne
        {
            public ImageSource ilkCarouselImage { get; set; }

        }
        private ObservableCollection<ImageCarouselOne> ilkCarouselView;
        public ObservableCollection<ImageCarouselOne> IlkCarouselView
        {
            get { return ilkCarouselView; }
            set
            {
                ilkCarouselView = value;
                OnPropertyChanged();
            }
        }

        //İkinci Carousel için resimleri tutacak liste oluşturma
        public class ImageCarouselTwo
        {
            public ImageSource ikinciCarouselImage { get; set; }

        }
        private ObservableCollection<ImageCarouselTwo> ikinciCarouselView;
        public ObservableCollection<ImageCarouselTwo> IkinciCarouselView
        {
            get { return ikinciCarouselView; }
            set
            {
                ikinciCarouselView = value;
                OnPropertyChanged();
            }
        }
        //Üçüncü Carousel için resimleri tutacak liste
        public class ImageCarouselThird
        {
            public ImageSource ucuncuCarouselImage { get; set; }

        }
        private ObservableCollection<ImageCarouselThird> ucuncuCarouselView;
        public ObservableCollection<ImageCarouselThird> UcuncuCarouselView
        {
            get { return ucuncuCarouselView; }
            set
            {
                ucuncuCarouselView = value;
                OnPropertyChanged();
            }
        }
        public AnasayfaViewModel() 
        {
            BindingContext = this;
            
            IlkCarouselView = new ObservableCollection<ImageCarouselOne>
            {
                new ImageCarouselOne{ilkCarouselImage = "https://cdn.beymen.com/bannerimages/BEYMEN_12G_Mobil_2022013115432842704.png"},
                new ImageCarouselOne{ilkCarouselImage = "https://cdn.beymen.com/bannerimages/12gmobil_2022022517311138166.png"},
                new ImageCarouselOne{ilkCarouselImage = "https://cdn.beymen.com/bannerimages/12gmobil_2022021421375512038.jpg"},
                new ImageCarouselOne{ilkCarouselImage = "https://cdn.beymen.com/bannerimages/12gmobil_2022022411344023272.png"},
                new ImageCarouselOne{ilkCarouselImage = "https://cdn.beymen.com/bannerimages/12gmobil_2022022411272308076.png"},

            };
            IkinciCarouselView = new ObservableCollection<ImageCarouselTwo>
            {
                new ImageCarouselTwo{ikinciCarouselImage ="https://cdn.beymen.com/bannerimages/BEYMEN_9G_Mobil_2022022418281949327.png"},
                new ImageCarouselTwo{ikinciCarouselImage ="https://cdn.beymen.com/bannerimages/9G_MOBIL_2022022420054818657.jpg"},
                new ImageCarouselTwo{ikinciCarouselImage ="https://cdn.beymen.com/bannerimages/BEYMEN_9G_Mobil_2022022114412501715.png"},
                new ImageCarouselTwo{ikinciCarouselImage ="https://cdn.beymen.com/bannerimages/BEYMEN_9G_Mobil_2021112408292311361.png"},

            };
            UcuncuCarouselView = new ObservableCollection<ImageCarouselThird>
            {
                new ImageCarouselThird{ucuncuCarouselImage ="https://cdn.beymen.com/bannerimages/9GMobile_2022010708234869014.jpg"},
                new ImageCarouselThird{ucuncuCarouselImage ="https://cdn.beymen.com/bannerimages/9GMobile_2022010708242629555.jpg"},
                new ImageCarouselThird{ucuncuCarouselImage ="https://cdn.beymen.com/bannerimages/9GMobile_2022010708252739998.jpg"},
                new ImageCarouselThird{ucuncuCarouselImage ="https://cdn.beymen.com/bannerimages/9GMobile_2022020408455443613.jpg"},

            };
        }
    }
}
