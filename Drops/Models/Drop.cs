using System;
using Xamarin.Forms.Maps;
using SQLite;
using System.Collections;



namespace Drops.Models
{
    // public class Drop : Pin
    public class Drop // : IEnumerable
    {
        // Constructor(s)        
        public Drop(Pin pin)
        {
            // how would we set ID
            //this.ID = App.Database.GetDropsCreated();  
            this.Latitude = pin.Position.Latitude;
            this.Longitude = pin.Position.Longitude;
            this.Label = pin.Label;
        }

        //// Properties
        //// perhaps the issue is that not all of these props are nonnull
        [PrimaryKey, AutoIncrement] // we need to grok how primarykey, and autoincrement are being implemented
        //public int ID { get; set; }
        private double Latitude { get; set; }
        private double Longitude { get; set; }
        public string Label { get; set; }
    }
}

