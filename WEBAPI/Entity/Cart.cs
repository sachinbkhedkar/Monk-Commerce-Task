using System;
using System.Collections.Generic;

namespace WEBAPI.Entity;

public partial class Cart
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Cartitem> Cartitems { get; set; } = new List<Cartitem>();
}
