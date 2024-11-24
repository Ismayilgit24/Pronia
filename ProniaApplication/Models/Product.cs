namespace ProniaApplication.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }

        //relational
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public List<ProductsImage> productsImages { get; set; }

    }
}
