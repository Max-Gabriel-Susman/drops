using System;
using Drops.Models;
using Drops.Views;
using Xamarin.Forms;


namespace Drops.ViewModels
{
    public class LoginPageViewModel : BindableObject
    {
        public LoginPageViewModel()
        {
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchResultsListViewPage
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
