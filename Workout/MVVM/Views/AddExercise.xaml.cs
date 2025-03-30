using Workout.MVVM.Models;
using Workout.MVVM.ViewModels;

namespace Workout.MVVM.Views;

public partial class AddExercise : ContentPage
{
    public AddExercise()
    {
        InitializeComponent();
    }

    private void Add_New_Exercise_Clicked(object sender, EventArgs e)
    {

        var viewModel = BindingContext as AddNewViewModel;
        var selectedCategory = viewModel?.Categories?.Where(cat => cat.IsSelected == true).FirstOrDefault();

        if (selectedCategory != null && !string.IsNullOrWhiteSpace(viewModel?.Exercise))
        {
            var exercise = new Exercise
            {
                Name = viewModel?.Exercise ?? string.Empty,
                CategoryId = selectedCategory.Id,
                IsCompleted = false
            };

            viewModel?.Exercises.Add(exercise);
            Navigation.PopAsync();
        }
        else
        {
            DisplayAlert("Category Null", "Please select a category", "OK");
        }
    }

    private async void Add_New_Category_Clicked(object sender, EventArgs e)
    {
        var viewModel = BindingContext as AddNewViewModel;
        string CategoryTitle = await DisplayPromptAsync("Add New Category", "Category Name", initialValue: "Add Me", maxLength: 100, keyboard: Keyboard.Text);
        if (!string.IsNullOrWhiteSpace(CategoryTitle))
        {
            var newCategory = new Category { Title = CategoryTitle, Id = viewModel?.Categories?.Count + 1 ?? 1, IsSelected = false };
            viewModel?.Categories.Add(newCategory);
        }
    }

}