using System;
using System.Collections.ObjectModel;


namespace Drops.Models
{
<<<<<<< HEAD
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
=======
    public class Userbase
    {
        // Shared Instance (Mock Data)
        private static ObservableCollection<User> Users = new ObservableCollection<User>()
        {
            new User("Admin", "Adminadmin")
        };

        public Userbase(){ }

        // Determines the validity of credential entry
        public static bool Authentication(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password)

                    return true;
            }

            return false;
        }

        // Attempts to create a new user while satisfying credential reqs
        public static string CreateUser(string username, string password)
        {
            // Checks for identical usernames
            foreach(User user in Users)
            {
                if (user.Username == username)

                    return "USERNAME_TAKEN";
            }

            // Checks for a valid Password length
            if (password.Length >= 8)
            {
                // Instantiates and appends a new user to the 'Users' collection
                Users.Add(new User(username, password));

                return "SUCCESS";
            }   
            else

                return "PASSWORD_INVALID";
>>>>>>> tmp
        }
    }
}
