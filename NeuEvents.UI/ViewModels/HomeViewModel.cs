using NeuEvent.Core.Implementation.Services;
using NeuEvent.Core.Interfaces.Services;
using NeuEvent.Core.Models;
using NeuEvents.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace NeuEvents.UI.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        //private IUserService _userSerivce;

        private INavigation _navigation;

        private IEventService _eventService;
        public ICommand NaviateToCreatePageCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public int EventId { get; set; } = 14;
        public int skip { get; set; } = 0;
        public int take { get; set; } = 3;

        public Event Event { get; set; }

        public HomeViewModel(INavigation navigation)
        {
            _eventService = new EventService();
            _navigation = navigation;
            NaviateToCreatePageCommand = new Command(async () => await OnNaviateToCreatePage());
        }

        public async void OnAppearing()
        {
            await GetEvent();
        }

        private async Task OnNaviateToCreatePage()
        {
            try
            {
                await _navigation.PushAsync(new NavigationPage(new Create()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task GetEvent()
        {
            try
            {
                Event = await _eventService.GetEventById(EventId);
                PropertyChanged(this, new PropertyChangedEventArgs("Event"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task GetEvents()
        {
            try
            {
                Event = await _eventService.GetEvents(skip, take);
                PropertyChanged(this, new PropertyChangedEventArgs("Event"));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
