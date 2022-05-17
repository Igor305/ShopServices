using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class WishList
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public string CardNumber { get; set; }
        public DateTime DateTime { get; set; }
        public int? ProdId { get; set; }
        public string Barcode { get; set; }
        public decimal? Qty { get; set; }
        public bool Deleted { get; set; }
        public string Description { get; set; }
    }
}
