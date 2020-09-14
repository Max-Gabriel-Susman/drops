using System;
using Xamarin.Forms.Maps;
using SQLite;


namespace Drops.Models
{
    public class Drop : Pin
    {
        // Constructor(s)
        public Drop() : base()
        {
            // how would we set ID

        }

        // Properties
        // perhaps the issue is that not all of these props are nonnull
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        
        

        // Methods
        public override string ToString()
        {
            return Label;
        }
         
    }
}

