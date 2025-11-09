using CommunityToolkit.Mvvm.ComponentModel;

namespace diet_planner.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    public string testProperty = "Hello Avalonia!";
}
