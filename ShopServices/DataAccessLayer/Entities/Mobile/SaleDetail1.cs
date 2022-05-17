using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class SaleDetail1
    {
        public long ChId { get; set; }
        public int PosId { get; set; }
        public int ProdId { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceWt { get; set; }
        public decimal SumWt { get; set; }
    }
}
