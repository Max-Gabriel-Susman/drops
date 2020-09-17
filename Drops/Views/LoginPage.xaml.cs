using System;
using System.Collections.Generic;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage
            {

            });
        }

        async void OnRegistrationButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchResultsListViewPage
            {

            });
        }

        async void OnLostCredentialsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchResultsListViewPage
            {

            });
        }
    }
}
