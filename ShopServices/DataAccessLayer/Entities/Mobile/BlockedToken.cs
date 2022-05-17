using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class BlockedToken
    {
        public int TokenId { get; set; }
        public bool Blocked { get; set; }
        public DateTime DateTime { get; set; }
        public string BlockingReason { get; set; }
    }
}
