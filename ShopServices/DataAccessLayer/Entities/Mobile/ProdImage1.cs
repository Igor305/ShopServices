using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProdImage1
    {
        public DateTime Dl { get; set; }
        public TimeSpan Tl { get; set; }
        public long? ProductId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
