using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class LogDiscExp3
    {
        public int DbiId { get; set; }
        public int LogId { get; set; }
        public long DcardChId { get; set; }
        public DateTime LogDate { get; set; }
        public int DiscCode { get; set; }
        public decimal? SumBonus { get; set; }
    }
}
