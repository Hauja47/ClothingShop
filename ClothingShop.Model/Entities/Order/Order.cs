namespace ClothingShop.Model
{
    public  class Order : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public decimal Total { get; set; }

        public decimal? Discount { get; set; }

        public decimal Balance { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public Guid? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        public Guid? PromotionId { get; set; }

        public Promotion? Promotion { get; set; }

        public IEnumerable<OrderItem> Items { get; set; }
    }
}
