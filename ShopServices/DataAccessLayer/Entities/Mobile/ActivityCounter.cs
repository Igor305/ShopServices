using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ActivityCounter
    {
        public DateTime Date { get; set; }
        public int TokenId { get; set; }
        public byte Type { get; set; }
        public long Incoming { get; set; }
        public long Accepted { get; set; }
    }
}
