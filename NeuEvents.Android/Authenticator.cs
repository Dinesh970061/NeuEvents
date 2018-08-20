//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Microsoft.IdentityModel.Clients.ActiveDirectory;
//using NeuEvent.Core.Interfaces.Services;
//using Xamarin.Forms;

//[assembly: Dependency(typeof(NeuEvents.Android.Authenticator))]


//namespace NeuEvents.Android
//{
//    class Authenticator : IAuthenticator
//    {
//        public async Task<AuthenticationResult> Authenticate(string tenantUrl, string graphResourceUri, string ApplicationID, string returnUri)
//        {
//            try
//            {
//                var authContext = new AuthenticationContext(tenantUrl);
//                if (authContext.TokenCache.ReadItems().Any()) authContext = new AuthenticationContext(authContext.TokenCache.ReadItems().FirstOrDefault().Authority);
//                var authResult = await authContext.AcquireTokenAsync(graphResourceUri, ApplicationID, new Uri(returnUri), new PlatformParameters((Activity)Forms.Context));
//                return authResult;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//    }
//}