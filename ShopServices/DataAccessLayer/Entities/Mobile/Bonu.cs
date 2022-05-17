using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Bonu
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime Ы { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool InUse { get; set; }
        public string Notes { get; set; }
    }
}
