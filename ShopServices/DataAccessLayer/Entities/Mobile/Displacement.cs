using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Displacement
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public string Endpoint { get; set; }
        public DateTime DateTime { get; set; }
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int DestStockId { get; set; }
        public int StateCodeFrom { get; set; }
        public int StateCodeTo { get; set; }
        public int? Tag { get; set; }
    }
}
