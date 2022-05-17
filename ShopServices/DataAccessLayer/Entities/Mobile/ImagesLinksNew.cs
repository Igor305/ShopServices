using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class ImagesLinksNew
    {
        public int PairId { get; set; }
        public int ObjectId { get; set; }
        public string ObjectType { get; set; }
        public int ImageId { get; set; }
        public int DetailedId { get; set; }
        public string Type { get; set; }
        public int Position { get; set; }
        public string Status { get; set; }
    }
}
