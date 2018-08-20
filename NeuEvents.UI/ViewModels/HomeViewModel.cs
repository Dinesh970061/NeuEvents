using NeuEvent.Core.Implementation.Services;
using NeuEvent.Core.Interfaces.Services;
using NeuEvents.UI.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeuEvents.UI.ViewModels
{
    public class HomeViewModel
    {
        //private IUserService _userSerivce;

        private INavigation _navigation;

        public int Id { get; set; } = 3;

        public ICommand NaviateToCreatePageCommand { get; set; }

        public HomeViewModel(INavigation navigation)
        {
           // _userSerivce = new UserService();
            _navigation = navigation;
            NaviateToCreatePageCommand = new Command(async () => await OnNaviateToCreatePage());
        }

        private async Task OnNaviateToCreatePage()
        {
            //await GetUser();
            try
            {
                await _navigation.PushAsync(new NavigationPage(new Create()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task GetUser()
        {
            try
            {
                //var user = await _userSerivce.GetUserById(Id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
