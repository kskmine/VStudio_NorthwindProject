﻿using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwndPro.Entities.Orm
{
    public partial class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
