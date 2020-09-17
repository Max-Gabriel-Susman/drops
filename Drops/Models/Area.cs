using System;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms.Maps;


namespace Drops.Models
{
    
    public class Area
    {
        // Constructor
        public Area(double latitude, double longitude)
        {
            this.Latitude = latitude;

            this.Longitude = longitude;

            this.Drops = new ObservableCollection<Drop>();

            this.DropMap = new DropMap();

            this.ViewHeight = 1.0; 
        }

        // Properties
        [PrimaryKey, AutoIncrement]

        private double Latitude { get; }

        private double Longitude { get; }

        private double ViewHeight { get; }

        // private int ID { get; set; }

        private bool IsActive { get; set; }

        public ObservableCollection<Drop> Drops { get; set; }

        public DropMap DropMap { get; set; }

        // Methods
        private void FocusDropMap()
        {
            DropMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(Latitude, Longitude), Distance.FromMiles(ViewHeight)));
        }


    }
}
