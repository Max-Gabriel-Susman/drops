using System;
using Xamarin.Forms.Maps;
using SQLite;


namespace Drops.Models
{
    public class DropPin : Pin
    {
<<<<<<< HEAD
        // basically just pins, but with special sauce, I may or may not include this class in the final version
=======
        // currently unimplemented

>>>>>>> tmp
        public DropPin()
        {
        }

        [PrimaryKey, AutoIncrement]
        public string Property { get; set; }
    }
}
