using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace MealPlanner.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public int selectedViewModelIndex;

        [RelayCommand]
        private void FirstIndex() 
        {
            SelectedViewModelIndex = 0;
        }

        [RelayCommand]
        private void SecondIndex()
        {
            SelectedViewModelIndex = 1;
        }

        [RelayCommand]
        private void ThirdIndex()
        {
            SelectedViewModelIndex = 2;
        }

        public MainViewModel()
        {
            selectedViewModelIndex = 0;
        }
    }
}
