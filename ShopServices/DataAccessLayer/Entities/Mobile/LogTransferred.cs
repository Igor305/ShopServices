using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class LogTransferred
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
