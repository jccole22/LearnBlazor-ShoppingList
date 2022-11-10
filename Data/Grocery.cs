//this is for form validation
using System.ComponentModel.DataAnnotations;


namespace LearnBlazorShoppingList.Data
{
    public class Grocery
    {
        // This was all we had/needed before form validation
        //public string Name { get; set; }
        //public double Price { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Name should be less than 30 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(.01, 100000, ErrorMessage = "Valid Price Range is $.01 to $100,000")]
        public double Price { get; set; }

    }
}
