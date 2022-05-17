using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Stock
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public decimal? StockLatitude { get; set; }
        public decimal? StockLongitude { get; set; }
        public string StockAdress { get; set; }
        public byte Plid { get; set; }
    }
}
