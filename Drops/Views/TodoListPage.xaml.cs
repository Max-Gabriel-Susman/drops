using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Drops.Models;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class TodoListPage : ContentPage
    {
        // Constructor(s)
        public TodoListPage()
        {
            InitializeComponent();
        }

        // Event Handler Methods
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
        }
    }
}
