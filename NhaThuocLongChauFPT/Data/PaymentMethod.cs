﻿using System;
using System.Collections.Generic;

namespace NhaThuocLongChauFPT.Data;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string? PaymentType { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
