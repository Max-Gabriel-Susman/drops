using System;
using System.Collections.ObjectModel;


namespace Drops.Models
{
    public class Userbase
    {
        // Shared Instance (Mock Data)
        private static ObservableCollection<User> Users = new ObservableCollection<User>()
        {
            new User("admin", "adminadmin")
        };

        public Userbase(){ }

        // Determines the validity of credential entry
        public bool Authentication(string username, string password)
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
        }
    }
}
