using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Coupondetail
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public decimal? Threshold { get; set; }

    public int? ProductId { get; set; }

    public int? RepetitionLimit { get; set; }

    public virtual Coupon Coupon { get; set; } = null!;
}
