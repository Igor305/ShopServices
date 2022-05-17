using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Sale2
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public string CardId { get; set; }
        public decimal SumWt { get; set; }
    }
}
