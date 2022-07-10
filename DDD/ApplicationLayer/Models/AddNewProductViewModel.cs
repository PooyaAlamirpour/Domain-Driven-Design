using System.ComponentModel.DataAnnotations;

namespace ApplicationLayer.Models
{
    /// <summary>
    /// Adding new product
    /// </summary>
    public class AddNewProductViewModel
    {
        /// <summary>
        /// Getting or setting the product name
        /// </summary>
        [Required(ErrorMessage = "Choose a name for product")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The product code is required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Enter quantity of the product")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "The cost of product is required")]
        public decimal Cost { get; set; }
    }
}