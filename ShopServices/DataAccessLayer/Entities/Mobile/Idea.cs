using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Idea
    {
        public long Id { get; set; }
        public int TokenId { get; set; }
        public long LogId { get; set; }
        public DateTime DateTime { get; set; }
        public int? StockId { get; set; }
        public int? ProdId { get; set; }
        public string Barcode { get; set; }
        public byte IdeaType { get; set; }
        public string Idea1 { get; set; }
        public string CardNumber { get; set; }
        public string CallbackPhone { get; set; }
    }
}
