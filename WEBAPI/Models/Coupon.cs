namespace WEBAPI.Models
{
    public enum CouponType
    {
        CartWise,
        ProductWise,
        BxGy
    }

    public class Coupon
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public CouponDetails Details { get; set; }
    }

    public class CouponDetails
    {
        public decimal? Threshold { get; set; } // For Cart-wise
        public int? ProductId { get; set; } // For Product-wise
        public List<BuyGet> BuyProducts { get; set; } // For BxGy
        public List<BuyGet> GetProducts { get; set; } // For BxGy
        public int RepetitionLimit { get; set; }
    }

    public class BuyGet
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class CartItem
    {
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class Cart
    {
        public List<CartItem> Items { get; set; }
    }
    public class ApplyCoupen
    {
        public Cart cart { get; set; }
    }

}
