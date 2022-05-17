using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Promo
    {
        public int PromoId { get; set; }
        public string Status { get; set; }
        public string AddPeriod { get; set; }
        public string Target { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public short Position { get; set; }
        public int CompanyId { get; set; }
        public string LangCode { get; set; }
    }
}
