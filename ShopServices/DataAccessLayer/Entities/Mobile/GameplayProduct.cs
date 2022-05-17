using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class GameplayProduct
    {
        public int GameplayId { get; set; }
        public string ProductCode { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
    }
}
