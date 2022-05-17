using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Stock1
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int Plid { get; set; }
        public string Address { get; set; }
        public bool? UseCards { get; set; }
        public bool? TransitStock { get; set; }
        public bool? MobAccept { get; set; }
        public decimal? LimitNeed { get; set; }
        public int? Rmempid { get; set; }
        public int? Tmempid { get; set; }
        public short? HeatingCode { get; set; }
        public int VenPeriod { get; set; }
        public decimal? LimitPpe { get; set; }
        public bool DenyFreeRet { get; set; }
        public bool? CancelCheque { get; set; }
        public bool? DenyEditQty { get; set; }
        public bool DenyBargChipRet { get; set; }
        public short StockAttribute { get; set; }
        public byte? FormatTtid { get; set; }
        public short? DepotCode { get; set; }
        public byte? CheckoutsQty { get; set; }
    }
}
