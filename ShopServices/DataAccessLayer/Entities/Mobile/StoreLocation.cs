using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class StoreLocation
    {
        public int StoreLocationId { get; set; }
        public int? CompanyId { get; set; }
        public short? Position { get; set; }
        public string Country { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Localization { get; set; }
        public string Status { get; set; }
        public int? StockId { get; set; }
        public string State { get; set; }
        public int? ExternalId { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Timework { get; set; }
        public string HideOnMob { get; set; }
        public string DangerLevel { get; set; }
        public string StatusWork { get; set; }
        public string StatusDelivery { get; set; }
    }
}
