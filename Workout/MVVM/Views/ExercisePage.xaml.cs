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
}