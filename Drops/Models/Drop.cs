using System;
using Xamarin.Forms.Maps;
using SQLite;


// let's try and use Drop as an intermediary between Pins and sqlite
namespace Drops.Models
{
    // public class Drop : Pin
    public class Drop 
    {
        // Constructor(s)
        // public Drop() : base()
        // Drops are to be exclusively created from existing pins and pins may be created from drops
        public Drop() { } // we should make sure we grok c# generics at some point or another

        public Drop(Pin pin)
        {
            // how would we set ID
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
        
        

        // Methods
        public override string ToString()
        {
            return Label;
        }
         
    }
}

