using System.Collections.ObjectModel;
using Workout.MVVM.Models;

namespace Workout.MVVM.ViewModels;

public class AddNewViewModel
{
    public string Exercise { get; set; } = string.Empty;
    public ObservableCollection<Exercise> Exercises { get; set; } = new ObservableCollection<Exercise>();
    public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();

}