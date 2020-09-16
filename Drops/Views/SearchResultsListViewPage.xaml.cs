using System;
using System.Collections.Generic;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class SearchResultsListViewPage : ContentPage
    {
        public SearchResultsListViewPage()
        {
            InitializeComponent();
            // BindingContext = new MainPageViewModel();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DropDetailViewPage
            {

            });
        }
    }
}