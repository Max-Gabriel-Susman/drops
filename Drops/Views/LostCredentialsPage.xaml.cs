using System;
using System.Collections.Generic;
using Drops.ViewModels;
using Xamarin.Forms;

namespace Drops.Views
{
    public partial class LostCredentialsPage : ContentPage
    {
        public LostCredentialsPage()
        {
            InitializeComponent();
            BindingContext = new LostCredentialsViewModel();
        }
    }
}
