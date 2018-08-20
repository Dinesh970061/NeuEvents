using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NeuEvents.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
            LocationPicker.Items.Add("Bangalore");
            LocationPicker.Items.Add("Hyderabad");
            LocationPicker.Items.Add("Kochi");
            EventTypePicker.Items.Add("Fundoo");
            EventTypePicker.Items.Add("Hackathon");
            EventTypePicker.Items.Add("Tournament");
        }

        async void Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new View()));
        }
    }
}