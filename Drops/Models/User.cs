using System;
using System.Collections.ObjectModel;
using SQLite;


namespace Drops.Models
{
    public class User
    {
<<<<<<< HEAD
        // Constructor
        public User(string username, string password, string email)
        {
            this.IsAdmin = false;

            this.IsValid = true;

=======
        // Constructors
        public User() { }

        public User(string username, string password)
        {
>>>>>>> tmp
            this.Username = username;

            this.Password = password;

<<<<<<< HEAD
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
=======
            this.OwnedAreas = new ObservableCollection<Area>();

            this.RecievedAreas = new ObservableCollection<Area>();
        }

        // Properties
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        private ObservableCollection<Area> OwnedAreas = new ObservableCollection<Area>();

        private ObservableCollection<Area> RecievedAreas = new ObservableCollection<Area>();

        // Currently populated with mockdata
        public ObservableCollection<Area> AllAreas = new ObservableCollection<Area>()
        {
            //new Area(0.0, 0.0),

            //new Area(0.0, 0.0),

            //new Area(0.0, 0.0)
        };

        // Methods
        public void UpdateUsername(string newUsername)
        {
            this.Username = newUsername;
>>>>>>> tmp
        }

        public void UpdatePassword(string newPassword)
        {
            this.Password = newPassword;
        }

        public void CreateArea(double latitude, double longitude, string name)
        {
            Area area = new Area(latitude, longitude, name);

            OwnedAreas.Add(area);

            AllAreas.Add(area);
        }

        public void ReceiveArea(Area area)
        {
            RecievedAreas.Add(area);

            AllAreas.Add(area);
        }

        public ObservableCollection<Area> GetAreas()
        {
            // Returns all areas available to the User
            return this.OwnedAreas;
        }

        // we want 
    //    public bool GetArea(int id, out Area areaWithID)
    //    {
    //        //return this.OwnedAreas.
    //        return true;
    //    }
    }
}
