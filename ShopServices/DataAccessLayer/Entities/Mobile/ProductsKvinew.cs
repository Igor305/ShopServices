using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProductsKvinew
    {
        public long ProdId { get; set; }
        public int? AssortmentId { get; set; }
        public int MinAmout { get; set; }
    }
}
