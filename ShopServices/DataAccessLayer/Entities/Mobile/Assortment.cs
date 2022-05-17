using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Assortment
    {
        public int AssortmentId { get; set; }
        public string Name { get; set; }
        public int MinAmout { get; set; }
        public DateTime Created { get; set; }
    }
}
