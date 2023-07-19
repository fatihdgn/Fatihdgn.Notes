using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatihdgn.Notes.App.Data;

public class NotesDB
{
    SQLiteAsyncConnection Database;

    public NotesDB() { }

    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        await Database.CreateTableAsync<Note>();
    }

    public async Task<List<Note>> GetItemsAsync()
    {
        await Init();
        return await Database.Table<Note>().ToListAsync();
    }

    public async Task<int> SaveItemAsync(Note item)
    {
        await Init();
        if (item.Id != Guid.Empty)
            return await Database.UpdateAsync(item);
        else
        {
            item.Id = Guid.NewGuid();
            return await Database.InsertAsync(item);
        }
    }

    public async Task<int> DeleteItemAsync(Note item)
    {
        await Init();
        return await Database.DeleteAsync(item);
    }
}
