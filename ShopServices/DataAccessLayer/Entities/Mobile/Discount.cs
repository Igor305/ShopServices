using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Discount
    {
        public long ChId { get; set; }
        public int DiscCode { get; set; }
        public string DiscName { get; set; }
        public bool ThisChargeOnly { get; set; }
        public bool ThisDocBonus { get; set; }
        public bool OtherDocsBonus { get; set; }
        public bool ChargeDcard { get; set; }
        public bool DiscOnlyWithDcard { get; set; }
        public bool ChargeAfterClose { get; set; }
        public int Priority { get; set; }
        public string AllowDiscs { get; set; }
        public string Shed1 { get; set; }
        public string Shed2 { get; set; }
        public string Shed3 { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool GenProcs { get; set; }
        public bool InUse { get; set; }
        public int DocCode { get; set; }
        public bool SimpleDisc { get; set; }
        public bool SaveDiscToDcard { get; set; }
        public bool SaveBonusToDcard { get; set; }
        public bool DiscFromDcard { get; set; }
        public bool ReProcessPosDiscs { get; set; }
        public string ValidOurs { get; set; }
        public string ValidStocks { get; set; }
        public bool AutoSelDiscs { get; set; }
        public string ShortCut { get; set; }
        public string Notes { get; set; }
        public bool GroupDisc { get; set; }
        public bool PrintInCheque { get; set; }
        public bool AllowZeroPrice { get; set; }
        public bool AllowEditQty { get; set; }
        public bool RedistributeDiscSumInBusket { get; set; }
    }
}
