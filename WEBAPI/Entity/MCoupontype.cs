using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class MCoupontype
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>();
}
