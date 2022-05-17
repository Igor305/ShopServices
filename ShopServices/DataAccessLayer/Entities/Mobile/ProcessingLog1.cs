using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProcessingLog1
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public string Endpoint { get; set; }
        public DateTime DateTime { get; set; }
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int StockId { get; set; }
        public int StateCode { get; set; }
        public int ProcessingState { get; set; }
        public string CardNumber { get; set; }
        public int? Tag { get; set; }
    }
}
