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
        //private ObservableCollection<Drop> naughty = new ObservableCollection<Drop>() ;

        // [PrimaryKey, AutoIncrement]
        // it was null because it was never instantiated god fucking damn't
        public static ObservableCollection<Drop> Drops = new ObservableCollection<Drop>();

        public DropMap() { }

    }
}
