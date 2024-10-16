using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Buyget
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public bool IsBuyProduct { get; set; }

    public virtual Coupon Coupon { get; set; } = null!;
}
