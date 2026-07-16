using System;
using System.Collections.Generic;

namespace June2026.Database.AppDbContextModels;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public int? Stock { get; set; }
}
