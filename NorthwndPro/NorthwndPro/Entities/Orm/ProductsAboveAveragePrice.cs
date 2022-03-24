using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwndPro.Entities.Orm
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
