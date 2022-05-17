using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProcessingState
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int ProcessingState1 { get; set; }
        public DateTime DateModified { get; set; }
        public int? Tag { get; set; }
    }
}
