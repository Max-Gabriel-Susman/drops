using System;
using Xamarin.Forms.Maps;
using SQLite;


namespace Drops.Models
{
    public class DropPin : Pin
    {
        // currently unimplemented

        public DropPin()
        {
        }

        [PrimaryKey, AutoIncrement]
        public string Property { get; set; }
    }
}
