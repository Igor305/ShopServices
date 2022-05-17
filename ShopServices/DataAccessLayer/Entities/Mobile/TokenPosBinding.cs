using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class TokenPosBinding
    {
        public int TokenId { get; set; }
        public int StockId { get; set; }
        public int Type { get; set; }
    }
}
