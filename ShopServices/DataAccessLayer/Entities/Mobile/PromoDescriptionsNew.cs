using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class PromoDescriptionsNew
    {
        public int PromoId { get; set; }
        public string Promo { get; set; }
        public string Url { get; set; }
        public string LangCode { get; set; }
    }
}
