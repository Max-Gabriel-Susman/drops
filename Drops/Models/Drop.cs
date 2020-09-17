using System;
using Xamarin.Forms.Maps;
using SQLite;
using System.Collections;
using SQLite;


namespace Drops.Models
{
    // public class Drop : Pin
    public class Drop // : IEnumerable
    {
        // Constructor(s)        
        public Drop() { } // we need this to use as an arg for the generics in DropDatabase

        static Drop()
        {
            DropsCreated = 0;
        }

        public Drop(Pin pin)
        {
            // how would we set ID
            //this.ID = App.Database.GetDropsCreated();  
            this.Latitude = pin.Position.Latitude;
            this.Longitude = pin.Position.Longitude;
            this.Label = pin.Label;
        }

        // Properties
        // perhaps the issue is that not all of these props are nonnull
        [PrimaryKey, AutoIncrement] // we need to grok how primarykey, and autoincrement are being implemented
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Label { get; set; }

        // Will implement with persistence later
        public static int DropsCreated { get; set; }
        
        // Methods
        public override string ToString()
        {
            return Label;
        }
         
    }
}

