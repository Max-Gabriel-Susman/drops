using System;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms.Maps;


namespace Drops.Models
{
    
    public class Area
    {
        public Area()
        {
        }

        [PrimaryKey, AutoIncrement]
        public Position Position { get; set; }

        public ObservableCollection<Drop> Drops { get; set; }


    }
}
