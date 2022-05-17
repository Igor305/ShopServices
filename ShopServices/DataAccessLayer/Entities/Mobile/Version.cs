using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Version
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
    }
}
