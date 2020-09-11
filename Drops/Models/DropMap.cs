using System;
using Xamarin.Forms.Maps;
using Drops.Models;
using System.Collections.Generic;


namespace Drops.Models
{
    public class DropMap : Map
    {

        private static List<Drop> drops = new List<Drop>();

        public static List<Drop> Drops
        {
            get { return drops; }
            set { drops = value; }
        }

        public DropMap() { }//: base(MapSpan) { }

    }
}
