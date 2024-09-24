namespace ThreadHaven.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price{ get; set; }
        public required string Size { get; set; }
        public string? Photo {  get; set; }

        // Foreign Key
        public required int CategoryId { get; set; }

        // Parent reference to Category Model
        public required Category Category { get; set; }

        // Child reference to OrderDetail
        public List<CartItem> CartItems { get; set; } 
        public List<OrderDetail> OrderDetails {  get; set; }    
    }
}
