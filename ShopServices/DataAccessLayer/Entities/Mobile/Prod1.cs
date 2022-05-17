using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Prod1
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string Um { get; set; }
        public string Notes { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId2 { get; set; }
        public int PgrId3 { get; set; }
        public bool InRems { get; set; }
        public bool? PrintSticker { get; set; }
        public int? Pcatsubgroupid { get; set; }
        public int? PcatKmid { get; set; }
        public int? MainProdId { get; set; }
        public short GuaranteeMonth { get; set; }
        public bool ProviderReturn { get; set; }
        public bool AmPos { get; set; }
        public short? DocTypeCode { get; set; }
        public short? DocInfoCode { get; set; }
        public DateTime? DocValidPeriod { get; set; }
        public byte? ProdIdroleId { get; set; }
        public string CellNumber { get; set; }
        public bool? FirstPriceProduct { get; set; }
        public int? BrendId { get; set; }
        public bool? TrackWms { get; set; }
        public bool? ActiveAssortment { get; set; }
        public int EpId { get; set; }
        public string AssortmentPriceName { get; set; }
        public string ProviderProdName { get; set; }
        public short? CodePriceSegment { get; set; }
        public int ReviewId { get; set; }
        public int MerchGrId { get; set; }
        public bool? AssPriceSeries { get; set; }
        public bool? ProdCardNotChecked { get; set; }
    }
}
