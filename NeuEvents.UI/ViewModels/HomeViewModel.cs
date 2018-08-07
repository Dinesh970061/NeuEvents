using NeuEvent.Core.Implementation.Services;
using NeuEvent.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeuEvents.UI.ViewModels
{
    public class HomeViewModel
    {
        private IUserService _userSerivce;

        public int Id { get; set; }

        public HomeViewModel()
        {
            _userSerivce = new UserService();
        }

        private void GetUser()
        {
            try
            {
                var user = _userSerivce.GetUserById(Id);
            }
            catch
            {

            }
        }
    }
}
