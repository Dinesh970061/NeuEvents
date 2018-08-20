using NeuEvents.UI.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeuEvents.UI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View : ContentPage
	{
		public View ()
		{
			InitializeComponent ();
		}

        async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new Register()));
        }
    }
}