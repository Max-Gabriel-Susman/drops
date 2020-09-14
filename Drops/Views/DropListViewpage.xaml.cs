using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using Drops.Models;
using Xamarin.Forms.Maps;
using SQLite;
using System.Threading.Tasks;
using Drops.Data;

namespace Drops.Views
{
    public partial class DropListViewpage : ContentPage
    {


        public DropListViewpage()
        {
            InitializeComponent();

            // we need to figure out how to implement swipe to delete, is this crossplatform?
            dropsListView.ItemsSource = DropMap.Drops;
            //dropsListView.ItemsSource = App.Database.GetDropsAsync();

            // using statement has a distinct set of functionality from using directive
            // using(SQLiteConnection conn = new SQLiteConnection(App.Fi))

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

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            // I think the issue here is I got a big ol dick
            //dropsListView.ItemsSource = await App.database.GetDropsAsync();
        }
    }
}
