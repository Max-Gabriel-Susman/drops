using System;
using Xamarin.Forms.Maps;
using Drops.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Drops.Models
{
    public class DropMap : Map
    {

        private static ObservableCollection<Drop> drops = new ObservableCollection<Drop>();

        public static ObservableCollection<Drop> Drops
        {
            get { return drops; }
            set { drops = value; }
        }

        public DropMap() { }

    }
}
