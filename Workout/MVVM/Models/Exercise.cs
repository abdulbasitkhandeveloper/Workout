using PropertyChanged;

namespace Workout.MVVM.Models;

[AddINotifyPropertyChangedInterface]
public class Exercise
{
    public string? Name { get; set; }
    public int CategoryId { get; set; }
    public bool IsCompleted { get; set; }
}