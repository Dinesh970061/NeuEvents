using NeuEvents.UI.Pages;
using NeuEvents.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Plugin.TabView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeuEvents
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
        TabViewControl tabView;
        public Home ()
		{
			InitializeComponent ();

            tabView = new TabViewControl(new List<TabItem>()
            {
                new TabItem("All", new Label{Text = "All Events are shown here", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand}),
                new TabItem("Fundoo", new Label{Text = "Fundoo Events are shown here", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand}),
                new TabItem("Hackathon", new Label{Text = "Hackathon Events are shown here", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand}),
                new TabItem("Tournament", new Label{Text = "Tournament Events are shown here", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand}),
            });
            tabView.HorizontalOptions = LayoutOptions.FillAndExpand;
            tabView.VerticalOptions = LayoutOptions.FillAndExpand;
            tabViewLayout.Children.Add(tabView);

            this.BindingContext = new HomeViewModel();
		}
        private async void TapImage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create());
        }
    }
}