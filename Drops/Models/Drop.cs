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

        }

        // Properties
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }

        // Methods
        public override string ToString()
        {
            return Label;
        }
         
    }
}

//namespace Drops.Models
//{
//    public class TodoItem
//    {
        //[PrimaryKey, AutoIncrement]
        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string Notes { get; set; }
        //public bool Done { get; set; }
//    }
//}