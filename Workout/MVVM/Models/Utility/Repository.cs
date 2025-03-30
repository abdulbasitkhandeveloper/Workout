using SQLite;

namespace Workout.MVVM.Models.Utility;

public class Repository
{
    SQLiteConnection con;

    public Repository()
    {
        con = new SQLiteConnection(DbConnection.DbPath, DbConnection.Flags );
        con.CreateTable<Item>();
    }

    public void AddItem(Item item)
    {
        int result = 0;
        try
        {
            result = con.Insert(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public List<Item> GetItems()
    {
        try
        {
            return con.Table<Item>().ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return null;
    }

    public Item GetItem(int id)
    {
        try
        {
            return con.Table<Item>().FirstOrDefault(x => x.Id == id);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        return null;
    }
    
    public void UpdateItem(Item item)
    {
        int result = 0;
        try
        {
            result = con.Update(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public void DeleteItem(int Id)
    {
        var item = GetItem(Id);
        if (item == null) return;

        int result = 0;
        try
        {
            result = con.Delete(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}
