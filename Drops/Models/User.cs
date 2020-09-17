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

            this.SharedAreas = new ObservableCollection<Area>();
        }

        // Properties
        [PrimaryKey, AutoIncrement]

        private string Username { get; set; }

        private string Password { get; set; }

        private ObservableCollection<Area> OwnedAreas { get; set; }

        private ObservableCollection<Area> SharedAreas { get; set; }

        // Methods
        public void UpdateUsername(string newUsername)
        {
            this.Username = newUsername;
        }

        public void UpdatePassword(string newPassword)
        {
            this.Password = newPassword;
        }

        public void CreateArea()
        {

        }

        public void ReceiveArea()
        {

        }

        public ObservableCollection<Area> GetAreas()
        {
            // Returns all areas available to the User
            return this.OwnedAreas;
        }

        //public Area GetArea()
        //{

        //}
    }
}
