using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ImagesNew
    {
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public int ImageX { get; set; }
        public int ImageY { get; set; }
        public byte[] Image { get; set; }
    }
}
