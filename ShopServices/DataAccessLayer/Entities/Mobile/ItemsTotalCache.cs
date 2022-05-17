using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ItemsTotalCache
    {
        public int TokenId { get; set; }
        public byte Type { get; set; }
        public DateTime DateTime { get; set; }
        public int? Total { get; set; }
        public int? Seen { get; set; }
    }
}
