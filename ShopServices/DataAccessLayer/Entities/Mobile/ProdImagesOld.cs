using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ProdImagesOld
    {
        public int ProdId { get; set; }
        public int ImageId { get; set; }
        public byte[] Image { get; set; }
    }
}
