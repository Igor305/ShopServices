using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class LogCache
    {
        public long Id { get; set; }
        public long LogId { get; set; }
        public byte LogType { get; set; }
        public int? ProdId { get; set; }
    }
}
