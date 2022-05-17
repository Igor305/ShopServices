using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class TokenBinding1
    {
        public int TokenId { get; set; }
        public int StockId { get; set; }
        public int Rights { get; set; }
        public int Type { get; set; }
    }
}
