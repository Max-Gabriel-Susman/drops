using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class SearchResultsListViewPage : ContentPage
    {
        public SearchResultsListViewPage()
        {
            InitializeComponent();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DropDetailViewPage
            {

            });
        }
    }
}