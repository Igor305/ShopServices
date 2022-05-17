using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
    }
}
