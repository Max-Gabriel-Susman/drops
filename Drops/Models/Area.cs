using System;
using System.Collections.ObjectModel;
<<<<<<< HEAD
using Xamarin.Forms.Maps;

=======
using SQLite;
using Xamarin.Forms.Maps;


>>>>>>> tmp
namespace Drops.Models
{
    
    public class Area
    {
        // Constructor
<<<<<<< HEAD
        public Area()
        {
            
            
        }

        // Properties
        private bool IsActive { get; set; }

        private Position Position { get; set; }

        private ObservableCollection<Drop> drops { get; set; }

        private string Name { get; set; }

        private string Owner { get; set; }

        // Method(s)
        private void InstantiateDropMap()
        {
            //DropMap dropMap = new DropMap()
            //{
            //    // Instantiate DropPins
            //}
=======
        public Area(double latitude, double longitude, string name)
        {
            this.Latitude = latitude;

            this.Longitude = longitude;

            this.Drops = new ObservableCollection<Drop>();

            this.DropMap = new DropMap();

            this.ViewHeight = 1.0;

            this.Name = name;
>>>>>>> tmp
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

        public string Name { get; set; }
        // Methods
        private void FocusDropMap()
        {
            DropMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(Latitude, Longitude), Distance.FromMiles(ViewHeight)));
        }


    }
}
