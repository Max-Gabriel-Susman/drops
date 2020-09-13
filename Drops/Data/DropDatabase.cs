using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using Drops.Models;


namespace Drops.Data
{
    public class DropDatabase
    {

        // all of this should be reusable
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        // Constructor(s)
        public DropDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(TodoItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(TodoItem)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }


        // CRUD Methods
        // Get 
        public Task<List<Drop>> GetDropsAsync()
        {
            return Database.Table<Drop>().ToListAsync();
        }

        public Task<List<Drop>> GetDropsNotDoneAsync()
        {
            return Database.QueryAsync<Drop>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<Drop> GetDropAsync(int id)
        {
            return Database.Table<Drop>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveDropAsync(Drop item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteDropAsync(TodoItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
