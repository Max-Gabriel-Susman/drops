using System;
using System.Collections.ObjectModel;
using SQLite;


namespace Drops.Models
{
    public class User
    {
        // Constructors
        public User() { }

        public User(string username, string password)
        {
            this.Username = username;

            this.Password = password;

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

        private ObservableCollection<Area> AllAreas = new ObservableCollection<Area>();

        // Methods
        public void UpdateUsername(string newUsername)
        {
            this.Username = newUsername;
        }

        public void UpdatePassword(string newPassword)
        {
            this.Password = newPassword;
        }

        public void CreateArea(double latitude, double longitude)
        {
            Area area = new Area(latitude, longitude);

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
