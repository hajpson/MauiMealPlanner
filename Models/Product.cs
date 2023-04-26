using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fats { get; set; }
        public double Price { get; set; }
    }
}
