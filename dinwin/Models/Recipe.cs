using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace dinwin.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required, Display(Name = "Recipe name")]
        public string Name { get; set; }
        [Required, Display(Name = "Ingredients")]
        public ICollection<Ingredient> Ingredients { get; set; }
        public string Directions { get; set; }
    }
}
