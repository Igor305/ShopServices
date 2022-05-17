using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class AssortmentProductsOld
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public int AssortmentId { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
