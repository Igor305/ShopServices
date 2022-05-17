using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Gameplay
    {
        public int GameplayId { get; set; }
        public string NameRu { get; set; }
        public string NameUa { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime FromDate { get; set; }
        public decimal LimitUah { get; set; }
        public int BonusCount { get; set; }
        public string Status { get; set; }
    }
}
