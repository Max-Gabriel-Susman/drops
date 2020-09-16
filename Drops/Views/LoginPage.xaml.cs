using System;
using System.Collections.Generic;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    // It's almost like hierarchical navigation has to be routed throudgh app and then main for it to work as opposed to app and then anything else
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        // Navigation
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MapPage
            {

            });
        }

        async void OnRegistrationButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage
            {

            });
        }

        async void OnLostCredentialsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LostCredentialsPage
            {

            });
        }
    }
}
