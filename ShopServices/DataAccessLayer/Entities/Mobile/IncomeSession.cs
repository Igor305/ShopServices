using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class IncomeSession
    {
        public long SessionId { get; set; }
        public int TokenId { get; set; }
        public string Endpoint { get; set; }
        public int StockId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public DateTime DateRegistered { get; set; }
        public int Invoices { get; set; }
        public string CardNumber { get; set; }
        public int? Tag { get; set; }
    }
}
