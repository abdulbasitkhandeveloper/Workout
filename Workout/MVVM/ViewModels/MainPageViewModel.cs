using System.Collections.ObjectModel;
using PropertyChanged;
using Workout.MVVM.Models;
namespace Workout.MVVM.ViewModels;


[AddINotifyPropertyChangedInterface]
public class MainPageViewModel
{
    public ObservableCollection<Category> Categories { get; set; }
    public ObservableCollection<Exercise> Exercises { get; set; }
    
    public MainPageViewModel()
    {
        Categories = new ObservableCollection<Category>();
        Exercises = new ObservableCollection<Exercise>();
        LoadData();
        Calculation();
    }

    public void Calculation()
    {
        foreach (Category category in Categories)
        {
            var exerciseByCategory = Exercises.Where(x => x.CategoryId == category.Id).ToList();
            var pendingExercises = exerciseByCategory.Where(x => x.IsCompleted == false).ToList();
            category.PendingExercises = pendingExercises.Count();
            var completedExercises = exerciseByCategory.Where(x => x.IsCompleted == true).ToList();
            category.Percentage = (float)completedExercises.Count / (float)exerciseByCategory.Count;
        }
     }

    private void LoadData()
    {
        Categories = new ObservableCollection<Category>()
        {
            new Category() { Id = 1, Title = "Abs" },
            new Category() { Id = 2, Title = "Lower Body" },
            new Category() { Id = 3, Title = "Legs" },
            new Category() { Id = 4, Title = "Arms" },
            new Category() { Id = 5, Title = "Full Body" },
            new Category() { Id = 6, Title = "Back" },
            new Category() { Id = 7, Title = "Shoulders" },
            new Category() { Id = 8, Title = "Biceps" },
            new Category() { Id = 9, Title = "Chest" }
        };

        Exercises = new ObservableCollection<Exercise>()
        {
            new Exercise() { Name = "Pushup", CategoryId = 9, IsCompleted = true },
            new Exercise() { Name = "Bicycle Crunch", CategoryId = 1, IsCompleted = false },
            new Exercise() { Name = "Running", CategoryId = 5, IsCompleted = false }, 
            new Exercise() { Name = "Pull-up", CategoryId = 6, IsCompleted = false },
            new Exercise() { Name = "Pull-down", CategoryId = 7, IsCompleted = false },
            new Exercise() { Name = "Bicep Curl", CategoryId = 8, IsCompleted = false }
        };

    }
}