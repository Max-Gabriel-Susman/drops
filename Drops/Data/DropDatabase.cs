using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using Drops.Models;
using Xamarin.Forms.Maps; // might delete later


namespace Drops.Data
{
    public class DropDatabase
    {
        // database is declared
        readonly SQLiteAsyncConnection _database;


        public DropDatabase(string dbPath)
        {
            // database is instantiated
            _database = new SQLiteAsyncConnection(dbPath);            
            _database.CreateTableAsync<User>().Wait();
        }

        // CRUD Methods

        // Read All
        public Task<List<User>> GetDropsAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        // Read
        public Task<User> GetDropAsync(int id)
        {
            return _database.Table<User>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        // Create
        public Task<int> SaveDropAsync(User user)
        {
            if (user.ID != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        // Delete
        public Task<int> DeleteDropAsync(User user)
        {
            return _database.DeleteAsync(user);
        }
    }
}
