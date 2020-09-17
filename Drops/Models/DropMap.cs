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

        private static ObservableCollection<Drop> drops = new ObservableCollection<Drop>();

        [PrimaryKey, AutoIncrement]
        public static ObservableCollection<Drop> Drops { get; set; }

        public DropMap() { }

    }
}
