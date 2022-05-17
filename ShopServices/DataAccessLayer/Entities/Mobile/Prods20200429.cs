using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Prods20200429
    {
        public int ProdId { get; set; }
        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public int Group1Id { get; set; }
        public string ProdNameUkr { get; set; }
        public string ProdNameRus { get; set; }
        public byte[] ProdImage { get; set; }
        public bool ProdIsNew { get; set; }
        public bool ProdIsExtraNew { get; set; }
        public bool ProdIsSale { get; set; }
    }
}
