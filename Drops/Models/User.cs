using System;
using System.Collections.ObjectModel;

namespace Drops.Models
{
    public class User
    {
        // Constructor
        public User(string username, string password, string email)
        {
            this.IsAdmin = false;

            this.IsValid = true;

            this.Username = username;

            this.Password = password;

            this.Email = email;
        }

        // Properties
        public bool IsAdmin { get;  }

        public bool IsValid { get; }

        public string Username { get; }

        public string Password { get; }

        public string Email { get; set; }

        // These are areas created and owned by the user, they may be shared with others, pins may be created, deleted and edited
        private ObservableCollection<Area> OwnedAreas { get;  set; }

        // These are the areas shared from other users, they cannot be shared by this user, pins may be edited but not created or deleted
        public ObservableCollection<Area> SharedAreas { private get; set; }

        // Methods
        // Should only be invoked by this User
        private void CreateArea(Area area)
        {
            this.OwnedAreas.Add(area);
        }

        private void DeactivateAccount()
        {
            // deactivates the account and hides shared areas from recipient users, however the account itself will not be deleted, and may be reactivated
        }

        private void DeactivateArea()
        {
            // deactivates the area by hiding it in recipient users SharedAreas collections
        }

        // Should only be invoked by other Users
        public void ShareArea(Area area)
        {
            this.SharedAreas.Add(area);
        }
    }
}
