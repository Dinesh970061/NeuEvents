using Microsoft.IdentityModel.Clients.ActiveDirectory;
using NeuEvent.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NeuEvents
{
	public partial class Login : ContentPage
	{
		public Login()
		{
			InitializeComponent();
		}
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Home());
            //try
            //{
            //    var data = await DependencyService.Get<IAuthenticator>().Authenticate(App.tenanturl, App.GraphResourceUri, App.ApplicationID, App.ReturnUri);
            //    App.AuthenticationResult = data;
            //    NavigateTopage(data);
            //}
            //catch (Exception ex)
            //{
            //    throw (ex);
            //}
        }
        //public async void NavigateTopage(AuthenticationResult data)
        //{
        //    await Navigation.PushModalAsync(new Home());
        //}
    }
}
