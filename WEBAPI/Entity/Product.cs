using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public float? Quantity { get; set; }

    public float? Rate { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Couponproduct> CouponproductFreeProducts { get; set; } = new List<Couponproduct>();

    public virtual ICollection<Couponproduct> CouponproductGetProducts { get; set; } = new List<Couponproduct>();
}
