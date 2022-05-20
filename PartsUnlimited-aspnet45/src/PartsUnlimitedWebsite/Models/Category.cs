using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
<<<<<<< HEAD
<<<<<<< HEAD
    // My fourth change in kristof1 branch
=======
    // wijziging in release
>>>>>>> release
=======
    // My fourth change in kristof1 branch -> merged
    // second change in Kristof1 branch
>>>>>>> kristof1
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}