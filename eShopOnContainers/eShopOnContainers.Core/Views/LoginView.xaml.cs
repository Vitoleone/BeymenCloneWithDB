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
using Firebase.Auth;
namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        LoginViewModel viewModel;
        

        public LoginView()
        {
            InitializeComponent();
            
            BindingContext = viewModel = new LoginViewModel();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
         
        }

        private async void ShowError()
        {
            await DisplayAlert("Giriş Başarısız!", "E-mail veya şifre yanlış. Tekrar deneyin!", "Tamam");

        }
    }
}