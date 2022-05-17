using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class BlockedActivity
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public byte Type { get; set; }
        public DateTime DateTime { get; set; }
        public string CardNumber { get; set; }
        public int? VersionCode { get; set; }
        public string Description { get; set; }
    }
}
