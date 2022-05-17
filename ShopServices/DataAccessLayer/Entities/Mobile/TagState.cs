using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class TagState
    {
        public int Id { get; set; }
        public string ForInstrument { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
