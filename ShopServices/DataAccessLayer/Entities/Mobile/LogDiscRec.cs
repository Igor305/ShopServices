﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class LogDiscRec
    {
        public int DbiId { get; set; }
        public int LogId { get; set; }
        public string DcardId { get; set; }
        public DateTime LogDate { get; set; }
        public int DiscCode { get; set; }
        public decimal? SumBonus { get; set; }
    }
}
