using MealPlanner.ViewModels;

namespace MealPlanner;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}

