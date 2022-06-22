using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using eShopOnContainers.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using eShopOnContainers.Droid.Interfaces;
using System.Runtime.CompilerServices;


[assembly: Xamarin.Forms.Dependency(typeof(AndroAuth))]
namespace eShopOnContainers.Droid.Interfaces
{
    public class AndroAuth : IFirebasetest
    {
        public async Task<string> DoLoginWithEP(string E, string P)
        {
            try
            {
                var user = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(E, P);
                var token = await user.User.GetIdTokenAsync(false);
                if (!string.IsNullOrEmpty(token.Token))
                {
                    return token.Token;
                }
                return "";
            }
            catch (System.Exception)
            {
                return "";
            }
            
        }

        public async Task<string> DoRegisterWithEP(string E, string P)
        {
            try
            {
                var user = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(E, P);
                var token = await user.User.GetIdTokenAsync(false);
                if (!string.IsNullOrEmpty(token.Token))
                {
                    return token.Token;
                }
                return "";
            }
            catch (System.Exception err)
            {
                return "";
            }
        }
    }
}