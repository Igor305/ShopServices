using System;

namespace BusinessLogicLayer.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public int? ShopNumber { get; set; }
        public DateTime? OpenFrom { get; set; }
        public int? StreetId { get; set; }
        public int StatusId { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public string WorkPhoneNumber { get; set; }
        public int? ShopRegionId { get; set; }     
        public string Address { get; set; }
        public string AddressComment { get; set; }
        public int? ShopWorkTimeId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public byte[] TerritorialManagerId { get; set; }
        public byte[] RegionalManagerId { get; set; }
        public byte[] DeputyAdministratorId { get; set; }
        public byte[] AdministratorId { get; set; }
        public string ShopWorkTimeString { get; set; }
    }
}
