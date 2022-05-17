using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Token1
    {
        public int TokenId { get; set; }
        public Guid InstanceGuid { get; set; }
        public DateTime DateTime { get; set; }
        public long? Key { get; set; }
    }
}
