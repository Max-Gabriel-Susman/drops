using System;
using System.Collections.ObjectModel;

namespace Drops.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ObservableCollection<String> Areas { get; set; }

        public User()
        {
        }
    }
}
