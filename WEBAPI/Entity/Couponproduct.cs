using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Couponproduct
{
    public int Id { get; set; }

    public int? CouponId { get; set; }

    public int? GetProductId { get; set; }

    public int? GetQuantity { get; set; }

    public float? Discount { get; set; }

    public float? Rate { get; set; }

    public int? FreeProductId { get; set; }

    public int? FreeQuantity { get; set; }

    public virtual Coupon? Coupon { get; set; }

    public virtual Product? FreeProduct { get; set; }

    public virtual Product? GetProduct { get; set; }
}
