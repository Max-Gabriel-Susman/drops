using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Drops.Models;
using Xamarin.Forms.Maps;

namespace Drops.Views
{
    public partial class DropListViewpage : ContentPage
    {


        public DropListViewpage()
        {
            InitializeComponent();

            dropsListView.ItemsSource = DropMap.Drops;

            BindingContext = this; // what is up with binding context  
        }

        // Handles when the user selects a listView Item
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (true)
            {
                await Navigation.PushAsync(new DropDetailViewPage
                {

                });
            }
        }

        // using keyword?
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // optionsListView.ItemsSource = new List<string> { "this", "is", "a", "test"};

        }
    }
}
