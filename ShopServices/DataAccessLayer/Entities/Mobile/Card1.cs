using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Card1
    {
        public long ChId { get; set; }
        public string DcardId { get; set; }
        public decimal Discount { get; set; }
        public decimal? SumCc { get; set; }
        public bool InUse { get; set; }
        public DateTime? Edate { get; set; }
        public int DctypeCode { get; set; }
        public decimal SumBonus { get; set; }
        public int Status { get; set; }
        public DateTime? Bdate { get; set; }
        public bool? ChatBot { get; set; }
    }
}
