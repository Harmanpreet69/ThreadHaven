namespace ThreadHaven.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        // Child reference to Product Model
        public List<Product> Products { get; set; }
    }
}
