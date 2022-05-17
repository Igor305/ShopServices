using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ExternalImage
    {
        public long Id { get; set; }
        public string Barcode { get; set; }
        public int? ProdId { get; set; }
        public byte[] Image { get; set; }
    }
}
