using SQLite;

namespace Workout.MVVM.Models;

[Table("Items")]
public class Item
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [Unique, NotNull, Indexed]
    public string Name { get; set; }
    public decimal  ItemPrice { get; set; }
    [MaxLength(100)]
    public string Description { get; set; }
}