using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Log
    {
        public long Id { get; set; }
        public byte Type { get; set; }
        public string Endpoint { get; set; }
        public DateTime DateTime { get; set; }
        public string Phone { get; set; }
        public string CardId { get; set; }
    }
}
