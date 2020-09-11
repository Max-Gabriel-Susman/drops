using System;


namespace Drops.Models
{
    public class Option
    {
        public string Title { get; set; }

        // This is needed to populate the listview cells
        public override string ToString()
        {
            return Title;
        }
    }
}