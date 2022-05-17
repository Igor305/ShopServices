using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Log1
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public byte Type { get; set; }
        public string Endpoint { get; set; }
        public DateTime DateTime { get; set; }
        public int? ProdId { get; set; }
        public int? StockId { get; set; }
        public string Barcode { get; set; }
        public decimal? Value { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Description { get; set; }
        public string CardNumber { get; set; }
        public long? ImageId { get; set; }
        public int? VersionCode { get; set; }
        public string FeedbackId { get; set; }
        public string IpAddress { get; set; }
        public string NetBiosName { get; set; }
        public string CallbackPhone { get; set; }
    }
}
