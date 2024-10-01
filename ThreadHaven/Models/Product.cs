using System.ComponentModel.DataAnnotations;

namespace ThreadHaven.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public required decimal Price{ get; set; }
        public required string Size { get; set; }
        public string? Photo {  get; set; }

        // Foreign Key
        [Display(Name = "Category")]
        public required int CategoryId { get; set; }

        // Parent reference to Category Model
        public Category? Category { get; set; }

        // Child reference to OrderDetail
        public List<CartItem>? CartItems { get; set; } 
        public List<OrderDetail>? OrderDetails {  get; set; }    
    }
}
