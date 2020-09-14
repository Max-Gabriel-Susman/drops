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
            _database.CreateTableAsync<Drop>().Wait();
        }

        // CRUD Methods

        // Read All
        public Task<List<Drop>> GetDropsAsync()
        {
            return _database.Table<Drop>().ToListAsync();
        }

        // Read
        public Task<Drop> GetDropAsync(int id)
        {
            return _database.Table<Drop>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        // Create
        public Task<int> SaveDropAsync(Drop drop)
        {
            if (drop.ID != 0)
            {
                return _database.UpdateAsync(drop);
            }
            else
            {
                return _database.InsertAsync(drop);
            }
        }

        // Delete
        public Task<int> DeleteDropAsync(Drop drop)
        {
            return _database.DeleteAsync(drop);
        }
    }
}
