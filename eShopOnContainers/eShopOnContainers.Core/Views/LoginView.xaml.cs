using eShopOnContainers.Core.Services;
using eShopOnContainers.Core.Services.User;
using eShopOnContainers.Core.ViewModels;
using eShopOnContainers.Core.Views;
using eShopOnContainers.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        LoginViewModel viewModel;
        IFirebaseAuthentication auth;

        public LoginView()
        {
            InitializeComponent();
            auth = DependencyService.Get<IFirebaseAuthentication>();
            BindingContext = viewModel = new LoginViewModel();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            string token = await auth.LoginWithEmailAndPassword(viewModel.Username, viewModel.Password);
            if (token != string.Empty)
            {
                Application.Current.MainPage = new GirisView();
            }
            else
            {
                ShowError();
            }
        }

        private async void ShowError()
        {
            await DisplayAlert("Authentication Failed", "Email or password are incorrect. Try again!", "OK");

        }
    }
}