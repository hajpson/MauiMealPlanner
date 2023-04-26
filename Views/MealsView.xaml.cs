using MealPlanner.ViewModels;

namespace MealPlanner.Views;

public partial class MealsView : ListView
{
	public MealsView()
	{
		InitializeComponent();
		BindingContext = new MealsViewModel();
	}
}