using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class RequestInfo
    {
        public int? ProdId { get; set; }
        public decimal? StockLatitude { get; set; }
        public decimal? StockLongitude { get; set; }
        public DateTime? DateTime { get; set; }
        public string CardNumber { get; set; }
        public decimal? ExternalPrice { get; set; }
        public string TokenId { get; set; }
    }
}
