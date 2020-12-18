using System;
using System.ComponentModel.DataAnnotations;

namespace ChefNDish.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        public int DishCalories { get; set; }

        [Required]
        public int DishTastiness { get; set; }

        [Required]
        public string Description { get; set; }

        public int ChefId { get; set; }

        public Chef Creator { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}