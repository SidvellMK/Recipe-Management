using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManagement.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public Step[] Steps { get; set; }
    }
}
