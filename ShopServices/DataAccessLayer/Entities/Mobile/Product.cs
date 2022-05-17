using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Product
    {
        public long ProductId { get; set; }
        public long ProductCode { get; set; }
        public string Barcode { get; set; }
        public string ProductType { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        public string DaysWarranty30 { get; set; }
        public string Kvi { get; set; }
        public string KviSubgroup { get; set; }
        public string Defender { get; set; }
        public int? MaxQty { get; set; }
        public byte? WarrantyMonths { get; set; }
    }
}
