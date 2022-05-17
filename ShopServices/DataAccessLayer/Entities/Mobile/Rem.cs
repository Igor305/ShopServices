using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Rem
    {
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public decimal? Qty { get; set; }
        public long? Count { get; set; }
    }
}
