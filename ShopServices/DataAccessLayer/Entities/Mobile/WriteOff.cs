using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class WriteOff
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public int TokenId { get; set; }
        public string Endpoint { get; set; }
        public int StockId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public DateTime DateRegistered { get; set; }
        public string CardNumber { get; set; }
        public int Goods { get; set; }
        public int? Tag { get; set; }
    }
}
