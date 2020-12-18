using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ChefNDish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public List<Dish> ChefDishes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}