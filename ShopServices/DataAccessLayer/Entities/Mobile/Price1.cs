using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Price1
    {
        public int ProdId { get; set; }
        public int Plid { get; set; }
        public decimal PriceMc { get; set; }
    }
}
