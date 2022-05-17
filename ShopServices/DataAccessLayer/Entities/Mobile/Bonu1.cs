using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Bonu1
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool InUse { get; set; }
        public string Notes { get; set; }
    }
}
