namespace ClothingShop.Model
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public Guid BrandId { get; set; }

        public Guid CategoryId { get; set; }

        public decimal? Rating { get; set; }

        public string? Description { get; set; }

        public Brand Brand { get; set; }

        public Category Category { get; set; }

        public virtual IEnumerable<Comment> Comments { get; set; }

        public virtual IEnumerable<Variant> Variants { get; set; }
    }
}