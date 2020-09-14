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

            dropsListView.ItemsSource = App.Database.GetDropsAsync().Result;

            BindingContext = this; 
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

        }
    }
}
