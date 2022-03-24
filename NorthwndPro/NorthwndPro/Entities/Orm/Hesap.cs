using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwndPro.Entities.Orm
{
    public partial class Hesap
    {
        public int Id { get; set; }
        public string TckimlikNo { get; set; }
        public string Ad { get; set; }
        public decimal Hesap1 { get; set; }
    }
}
