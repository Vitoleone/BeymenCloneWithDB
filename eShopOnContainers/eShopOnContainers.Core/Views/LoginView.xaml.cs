﻿using eShopOnContainers.Core.Services;
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
using eShopOnContainers.Services;
using eShopOnContainers.Core.Interfaces;

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
            string email = txtEmail.Text;
            string pass = txtPass.Text;

            var fblogin = DependencyService.Get<IFirebasetest>();
            string token = await fblogin.DoLoginWithEP(email, pass);

            if (!string.IsNullOrEmpty(token))
            {
                await Navigation.PushAsync(new Anasayfa());
            }
            else
            {
                await DisplayAlert("bilgi", "E mail veya şifre yanlış!", "OK");

            }

            //await Navigation.PushAsync(new Anasayfa());

        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;

            var fblogin = DependencyService.Get<IFirebasetest>();
            string token = await fblogin.DoRegisterWithEP(email, pass);
            if (!string.IsNullOrEmpty(token))
            {
                await DisplayAlert("bilgi", "Kayıt işlemi başarılı.", "OK");
            }
            else
            {
                await DisplayAlert("bilgi", "Bir hata oluştu.", "OK");

            }
        }

        private async void ShowError()
        {
            await DisplayAlert("Giriş Başarısız!", "E-mail veya şifre yanlış. Tekrar deneyin!", "Tamam");

        }
    }
}