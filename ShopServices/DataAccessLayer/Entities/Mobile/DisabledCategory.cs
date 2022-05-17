using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class DisabledCategory
    {
        public byte Level { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public bool Disabled { get; set; }
    }
}
