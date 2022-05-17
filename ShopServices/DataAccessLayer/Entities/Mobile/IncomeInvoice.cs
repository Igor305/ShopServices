using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class IncomeInvoice
    {
        public long SessionId { get; set; }
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int DestStockId { get; set; }
        public int StateCode { get; set; }
        public decimal? Sum { get; set; }
        public int Goods { get; set; }
        public int? Tag { get; set; }
        public bool Nacc { get; set; }
    }
}
