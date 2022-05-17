using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class EventHistory
    {
        public long EventId { get; set; }
        public string Procedure { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
    }
}
