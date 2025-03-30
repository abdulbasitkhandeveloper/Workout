using Workout.MVVM.ViewModels;

namespace Workout.MVVM.Views;

public partial class ExercisePage : ContentPage
{
    MainPageViewModel vm = new MainPageViewModel();
    public ExercisePage()
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private void CheckBox_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        vm.Calculation();
    }
    
    private async void Button_OnClicked(object sender, EventArgs e)
    {

        var model = new AddExercise {
            BindingContext = new AddNewViewModel
            {
                Exercises = vm.Exercises,
                Categories = vm.Categories,
            }
        };
       
        await Navigation.PushAsync(model);
    }

}