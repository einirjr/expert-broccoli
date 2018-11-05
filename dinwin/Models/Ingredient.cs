using System.ComponentModel.DataAnnotations;

namespace dinwin.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        [Required, Display(Name = "Ingredient")]
        public string Name { get; set; }
        [EnumDataType(typeof(FoodGroup))]
        public FoodGroup Category { get; set; }
    }
}
