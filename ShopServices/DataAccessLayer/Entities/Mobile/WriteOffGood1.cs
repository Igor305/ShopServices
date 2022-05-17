using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class WriteOffGood1
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public int ProdId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal? Qty { get; set; }
        public string Um { get; set; }
        public int? Tag { get; set; }
    }
}
