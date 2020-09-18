using System;
using Xamarin.Forms.Maps;
using Drops.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;


namespace Drops.Models
{
    public class DropMap : Map
    {
<<<<<<< HEAD
        // Constructors
        public DropMap() { }

        public DropMap(/* ObservableCollection<Drop> drops ,*/ Position positon)
        {
            //this.Drops = drops;

            //this.Position = Position;

            //this.Type = "Hybrid";

            //this.Distance = 1.0;
        }

        // Properties
        public static ObservableCollection<Drop> Drops { get; set; }

        public Position Position { get; set; }

        public double Distance { get; set; }

        public string Type { get; set; }

        // Methods
        public void UpdatePosition()
        {
            // updates the position of the dropmap
        }
=======
        // Constructor(s)
        // I don't know if we'll actually need this once we're carrying out transactions against the datbase with users
        public DropMap() { }

        public DropMap(double latitude, double longitude)
        {
            this.Latitude = latitude;

            this.Longitude = longitude;

            this.Distance = 1.0;
        }

        // Properties
        public static ObservableCollection<Drop> Drops = new ObservableCollection<Drop>();

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Distance { get; set; }
>>>>>>> tmp
    }
}
