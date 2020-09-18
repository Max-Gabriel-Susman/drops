using System;
using System.Collections.Generic;
using Drops.Models;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    // It's almost like hierarchical navigation has to be routed throudgh app and then main for it to work as opposed to app and then anything else
    public partial class LoginPage : ContentPage
    {
        // Constructor
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }

<<<<<<< HEAD
        // Navigation
        async void OnLoginButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MapPage
            {

            });
=======
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


>>>>>>> tmp
        }

        async void OnRegistrationButtonClicked(object sender, EventArgs e)
        {
<<<<<<< HEAD
            await Navigation.PushAsync(new RegistrationPage
=======
            await Navigation.PushAsync(new SearchResultsListViewPage
>>>>>>> tmp
            {

            });
        }

        async void OnLostCredentialsButtonClicked(object sender, EventArgs e)
        {
<<<<<<< HEAD
            await Navigation.PushAsync(new LostCredentialsPage
=======
            await Navigation.PushAsync(new SearchResultsListViewPage
>>>>>>> tmp
            {

            });
        }
    }
}
