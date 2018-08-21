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

        private HomeViewModel _homeViewModel;

        public Home()
        {
            InitializeComponent();
            _homeViewModel = new HomeViewModel(Navigation);
            this.BindingContext = _homeViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _homeViewModel.OnAppearing();
        }
    }
}