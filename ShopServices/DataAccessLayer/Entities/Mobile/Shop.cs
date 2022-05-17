using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Shop
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public decimal? GeoX { get; set; }
        public decimal? GeoY { get; set; }
        public int? GeoDistance { get; set; }
        public string GeoDistanceMsg { get; set; }
        public string BarcodeRec { get; set; }
        public string BarcodeExp { get; set; }
        public string FilePath { get; set; }
    }
}
