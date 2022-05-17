using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class DisabledStock
    {
        public int StockId { get; set; }
        public bool Disabled { get; set; }
    }
}
