using System;
using System.Collections.Generic;
using System.Windows.Input;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class DropListViewpage : ContentPage
    {
        public DropListViewpage()
        {
            InitializeComponent();

            // dropsListView.ItemsSource = App.Database.GetDropsAsync().Result;
            
            //DeleteCommand = new Command(OnDeleteDrop);

            BindingContext = this;
            // BindingContext = new MainPageViewModel();
        }

        // Properties
        public ICommand DeleteCommand { get; }

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

        async void OnDeleteDrop(object sender, EventArgs args)
        {
            // App.Database.DeleteDropAsync();
        }
    }
}
