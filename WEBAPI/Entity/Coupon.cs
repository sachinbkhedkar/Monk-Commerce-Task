using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Coupon
{
    public int Id { get; set; }

    public int Type { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Buyget> Buygets { get; set; } = new List<Buyget>();

    public virtual ICollection<Coupondetail> Coupondetails { get; set; } = new List<Coupondetail>();

    public virtual MCoupontype TypeNavigation { get; set; } = null!;
}
