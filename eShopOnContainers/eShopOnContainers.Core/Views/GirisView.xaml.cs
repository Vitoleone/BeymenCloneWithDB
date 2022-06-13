using eShopOnContainers.Core.Services;
using eShopOnContainers.Core.Services.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class GirisView : ContentPage
    {
        IFirebaseAuthentication auth;

        public GirisView()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthentication>();
        }

        private async void SignOutButton_Clicked(object sender, EventArgs e)
        {
            var signedOut = auth.SignOut();
            if (signedOut)
            {
                Application.Current.MainPage = new LoginView();
            }
        }
    }
}