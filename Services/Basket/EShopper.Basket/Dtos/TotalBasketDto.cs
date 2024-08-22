namespace EShopper.Basket.Dtos
{
    public class TotalBasketDto
    {
        public string UserId { get; set; }
        public string? DiscountCode { get; set; }
        public int? DiscountRate { get; set; }

        public List<BasketItemDto> basketItem { get; set; }

        public decimal TotalPrice { get => basketItem.Sum(x => x.Quantity * x.Price); }
    }
}
