using System;
using System.Collections.Generic;
using Drops.Models;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class LoginPage : ContentPage
    {
        // Constructor
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

        // Properties
        public string UsernameEntry { get; set; }

        private string PasswordEntry { get; set; }


        // Event Handlers
        void OnUsernameEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            //string oldText = e.OldTextValue;
            UsernameEntry = e.NewTextValue;

            System.Diagnostics.Debug.WriteLine(UsernameEntry);
        }

        void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            //string oldText = e.OldTextValue;
            PasswordEntry = e.NewTextValue;

            System.Diagnostics.Debug.WriteLine(PasswordEntry);
        }


        async void OnLoginButtonClicked(object sender, EventArgs e)
        {

            // Authenticate Credentials
            if (Userbase.Authentication(UsernameEntry, PasswordEntry))


                // Navigate to the Applications Content
                await Navigation.PushAsync(new MapPage
                {
                    ActiveUser = new User(UsernameEntry, PasswordEntry)
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
