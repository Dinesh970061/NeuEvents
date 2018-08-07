using NeuEvents.UI.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace NeuEvents
{
	public partial class App : Application
	{
        private NavigationPage Home;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            Home = new NavigationPage(new Create());
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
