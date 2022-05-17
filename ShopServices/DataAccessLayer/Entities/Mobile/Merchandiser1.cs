using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Merchandiser1
    {
        public int MerchandiserId { get; set; }
        public DateTime? ToDate { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int CodeGms { get; set; }
        public string NameGms { get; set; }
        public string GroupProducts { get; set; }
        public string Region { get; set; }
        public string NameRegionManager { get; set; }
        public string PhoneRegionManager { get; set; }
        public string Barcode { get; set; }
        public string Notes { get; set; }
    }
}
