using System;
using SQLite;


namespace Drops.Models
{
    public class Option
    {
        [PrimaryKey, AutoIncrement]
        public string Title { get; set; }

        // This is needed to populate the listview cells
        public override string ToString()
        {
            return Title;
        }
    }
}