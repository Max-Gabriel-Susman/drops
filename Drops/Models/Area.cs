using System;
using System.Collections.ObjectModel;
using Xamarin.Forms.Maps;

namespace Drops.Models
{
    public class Area
    {
        // Constructor
        public Area()
        {
            
            
        }

        // Properties
        private bool IsActive { get; set; }

        private Position Position { get; set; }

        private ObservableCollection<Drop> drops { get; set; }

        private string Name { get; set; }

        private string Owner { get; set; }

        // Method(s)
        private void InstantiateDropMap()
        {
            //DropMap dropMap = new DropMap()
            //{
            //    // Instantiate DropPins
            //}
        }
    }
}
