using System;
using Xamarin.Forms.Maps;
using Drops.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Drops.Models
{
    public class DropMap : Map
    {
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
    }
}
