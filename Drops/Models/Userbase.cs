using System;
using System.Collections.ObjectModel;


namespace Drops.Models
{
    static class Userbase
    {
        // Constructor
        static Userbase()
        {
        }

        // Properties
        static ObservableCollection<User> Users { get; set; }



        // Methods
        static void DeleteUser()
        {
            // Deletes the User and all of their areas
        }
    }
}
