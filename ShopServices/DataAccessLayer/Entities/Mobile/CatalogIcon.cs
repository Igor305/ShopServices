using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class CatalogIcon
    {
        public byte Level { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public int? IconId { get; set; }
    }
}
