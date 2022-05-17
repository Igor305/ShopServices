using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ItemsSeenCache
    {
        public int TokenId { get; set; }
        public byte Type { get; set; }
        public int ItemId { get; set; }
        public DateTime DateTime { get; set; }
        public byte? Value { get; set; }
    }
}
