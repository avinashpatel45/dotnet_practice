namespace Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public int StockQuantity { get; set; }
    }

}
