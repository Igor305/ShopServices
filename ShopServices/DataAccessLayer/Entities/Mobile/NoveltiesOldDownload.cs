using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class NoveltiesOldDownload
    {
        public int ProdId { get; set; }
        public decimal? SalePrice { get; set; }
        public DateTime SaleStart { get; set; }
        public DateTime SaleEnd { get; set; }
        public bool IsNewest { get; set; }
        public bool IsExtraNewest { get; set; }
        public bool IsSale { get; set; }
    }
}
