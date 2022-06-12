using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErkekKategoriView : ContentPageBase
    {
        public ErkekKategoriView()
        {
            InitializeComponent();
            BindingContext = this;
        }
        public ICommand GoBackCommand => new Command(execute: () => { Navigation.PushAsync(new SearchView()); });
        private void ErkekSaat(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ErkekSaatView());

        }

        private void ErkekGiyim(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ErkekGiyimView());
        }
        private void ErkekAyakkabi(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ErkekAyakkabiView());
        }
    }
}