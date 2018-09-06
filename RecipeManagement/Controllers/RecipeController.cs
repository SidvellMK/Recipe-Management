using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeManagement.Models;

namespace RecipeManagement.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private static string[] Recipes = new[]
        {
            "Fruit Salad", "Cheese Cakes"
        };

        [HttpGet("[action]")]
        public IEnumerable<Recipe> UserRecipes()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Recipe
            {
                Title = Recipes[rng.Next(Recipes.Length)]
            });
        }
    }
}