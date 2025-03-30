using SQLite;

namespace Workout.MVVM.Models.Utility;

public static class DbConnection
{
    private const string DbFileName = "Maui.db";
    public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite |
                                         SQLiteOpenFlags.Create |
                                         SQLiteOpenFlags.SharedCache;

    public static string DbPath
    {
        get
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DbFileName);
        }
    }
}