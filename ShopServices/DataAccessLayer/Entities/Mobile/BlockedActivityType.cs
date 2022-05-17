using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class BlockedActivityType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public int? Limit { get; set; }
        public string Description { get; set; }
    }
}
