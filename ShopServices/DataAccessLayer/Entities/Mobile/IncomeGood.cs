using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class IncomeGood
    {
        public long SessionId { get; set; }
        public long ChId { get; set; }
        public int Pos { get; set; }
        public int ProdId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Fact { get; set; }
        public string Um { get; set; }
        public decimal? Price { get; set; }
        public int? Tag { get; set; }
    }
}
