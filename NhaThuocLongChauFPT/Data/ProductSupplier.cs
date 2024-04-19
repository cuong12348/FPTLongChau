using System;
using System.Collections.Generic;

namespace NhaThuocLongChauFPT.Data;

public partial class ProductSupplier
{
    public int ProductId { get; set; }

    public int? SupplierId { get; set; }

    public virtual Product? Product { get; set; }
}
