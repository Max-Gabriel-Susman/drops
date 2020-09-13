using System;
using System.Collections.Generic;
using Drops.Models;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class TodoItemPage : ContentPage
    {
        // Constructor(s)
        public TodoItemPage()
        {
            InitializeComponent();
        }

        // Event Handler Methods
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
