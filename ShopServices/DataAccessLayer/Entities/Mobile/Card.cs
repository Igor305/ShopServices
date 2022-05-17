using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Card
    {
        public string CardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Notes { get; set; }
        public decimal SumBonus { get; set; }
    }
}
