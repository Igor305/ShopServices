using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class PersonCard1
    {
        public int PersonId { get; set; }
        public string Notes { get; set; }
        public long DcardChId { get; set; }
    }
}
