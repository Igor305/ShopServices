using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class BonusDetail
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Action { get; set; }
        public decimal SumCc { get; set; }
        public decimal Brate { get; set; }
        public string Notes { get; set; }
        public string ValidStocks { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
