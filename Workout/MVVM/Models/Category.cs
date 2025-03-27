using PropertyChanged;

namespace Workout.MVVM.Models;

[AddINotifyPropertyChangedInterface]
public class Category
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public int PendingExercises { get; set; }

    public float Percentage { get; set; }
} 