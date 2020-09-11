using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Drops.Models;

namespace Drops.Views
{
    public partial class MapPage : ContentPage
    {
        // MARK: - Constructors
        public MapPage()
        {
            InitializeComponent();

            dropMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(41.7377780, -111.8308330), Distance.FromMiles(1.0)));
        }

        // MARK: - UIElements



        // MARK: - Methods
        // I think best practice is going to be migrating these methods to another class?
        // Handles Navigation to SearchResultsListViewPage
        async void OnSearchBarButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchResultsListViewPage
            {

            });
        }

        // Handles Navigation to OptionsListViewPage
        async void OnOptionsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OptionsListViewPage
            {
                
            });
        }

        // Handles Navigation to PinsListViewPage
        async void OnPinsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DropListViewpage
            {

            });
        }

        // Handles Switching between satellite(Hybrid) and street map views INACTIVE
        async void OnPeopleButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new PeopleListViewPage
            {

            });
        }

        async void HomeOwnerStatusSelection()
        {
            string timeEntry;

            string homeOwnerStatus = DisplayActionSheet("Home Owner Status", "Cancel", null, "Not Home", "Not Interested", "Not Qualified", "Credit Check", "Call Back", "Under Contract").Result;

            if (homeOwnerStatus == "Not Interested" || homeOwnerStatus == "UnderContract" || homeOwnerStatus == "Not Home") { }

            else if (homeOwnerStatus == "Come Back Later")

                // invokes TimeEntryPrompt to set a return time for the Technician
                timeEntry = await DisplayPromptAsync("Question 1", "What's your name?");

            else if (homeOwnerStatus == "Appointment Scheduled") { }

            // Navigate to AppointmentSchedulingPage
        }

        // Handles Drop Creation
        void OnMapClicked(object sender, MapClickedEventArgs e)
        {

            var drop = new Drop()
            {
                Position = new Position(e.Position.Latitude, e.Position.Longitude),

                Label = "Unknown"
            };

            dropMap.Pins.Add(drop);

            DropMap.Drops.Add(drop);
        }
    }
}