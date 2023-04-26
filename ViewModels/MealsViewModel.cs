using CommunityToolkit.Mvvm.ComponentModel;
using MealPlanner.Models;
using System.Collections.ObjectModel;

namespace MealPlanner.ViewModels
{
    public partial class MealsViewModel : ObservableObject
    {
        public ObservableCollection<Meal> Meals { get; set; }

        public MealsViewModel()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Test product",
                    Description = "Short first product description",
                    Calories = 300,
                    Proteins = 50,
                    Carbohydrates = 100,
                    Fats = 20,
                    Price = 5
                },
                new Product
                {
                    Id = 2,
                    Name = "Test second product",
                    Description = "Short second product description",
                    Calories = 200,
                    Proteins = 20,
                    Carbohydrates = 120,
                    Fats = 15,
                    Price = 3
                }
            };

            Meals = new ObservableCollection<Meal>
            {
                new Meal
                {
                    Id = 1,
                    Name = "Test meal one",
                    Description = "Short desciption for first test meal",
                    Products = products,
                    Calories = products.Select(x => x.Calories).Sum(),
                    Proteins = products.Select(x => x.Proteins).Sum(),
                    Carbohydrates = products.Select(x => x.Carbohydrates).Sum(),
                    Fats = products.Select(x => x.Fats).Sum(),
                    Price = products.Select(x => x.Price).Sum(),
                },
                new Meal
                {
                    Id = 2,
                    Name = "Test meal two",
                    Description = "Short desciption for second test meal",
                    Products = products,
                    Calories = products.Select(x => x.Calories).Sum(),
                    Proteins = products.Select(x => x.Proteins).Sum(),
                    Carbohydrates = products.Select(x => x.Carbohydrates).Sum(),
                    Fats = products.Select(x => x.Fats).Sum(),
                    Price = products.Select(x => x.Price).Sum(),
                }
            };
        }
    }
}
