﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class DisabledProd1
    {
        public int ProdId { get; set; }
        public DateTime? DateTimeFrom { get; set; }
        public DateTime? DateTimeTo { get; set; }
        public bool Disabled { get; set; }
    }
}
