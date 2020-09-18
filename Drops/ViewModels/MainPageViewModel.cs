using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Drops.Models;
using Drops.Views;


namespace Drops.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        

        public ObservableCollection<Drop> Drops { get; set; } // = DropMap.Drops;

        public ObservableCollection<Pin> Pins { get; set; } // = DropMap.Drops;

        public ICommand DeleteCommand { get; }

        public MainPageViewModel()
        {

            Drops = DropMap.Drops;

            DeleteCommand = new Command(OnDeleteTapped);

        }

        private void OnDeleteTapped(object obj)
        {
            var drop = obj as Drop;

            Drops.Remove(drop);

            
        }

        //async void OnLoginButtonClicked(object sender, EventArgs e)
        //{

        //    await Navigation.PushAsync(new MainPage
        //    {

        //    });
        //}
    }
}
