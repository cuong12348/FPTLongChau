﻿using System;
using System.Collections.Generic;

namespace NhaThuocLongChauFPT.Data;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
