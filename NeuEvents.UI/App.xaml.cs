using NeuEvents.UI.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace NeuEvents
{
	public partial class App : Application
	{
        public static string ApplicationID = "754f2c78-bfcd-44d5-8c95-b4e3b008c7f8";
        //modify your Azure tenant  
        public static string tenanturl = "https://login.microsoftonline.com/neudesic.onmicrosoft.com/";
        //Update your return url  
        public static string ReturnUri = "https://neu-event-client-test.azurewebsites.net/";
        //No need to change  
        public static string GraphResourceUri = "https://graph.microsoft.com/";
        //public static AuthenticationResult AuthenticationResult = null;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            //Home = new NavigationPage(new Create());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
