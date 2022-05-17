using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class AssortmentList
    {
        public int AmPosCode { get; set; }
        public short AmPosPriceList { get; set; }
        public int AssortmentCode { get; set; }
        public string Notes { get; set; }
        public string BarCode { get; set; }
    }
}
