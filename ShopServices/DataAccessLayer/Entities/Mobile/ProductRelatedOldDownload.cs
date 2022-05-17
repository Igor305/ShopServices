using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProductRelatedOldDownload
    {
        public long Id { get; set; }
        public long ProductCode { get; set; }
        public long RelatedProductCode { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
