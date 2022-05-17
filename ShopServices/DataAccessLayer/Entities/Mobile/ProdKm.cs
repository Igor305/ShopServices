using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProdKm
    {
        public long ChId { get; set; }
        public int PcatKmid { get; set; }
        public string PcatKmname { get; set; }
        public string Notes { get; set; }
    }
}
