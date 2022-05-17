using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string UaempName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpParName { get; set; }
        public string UaempLastName { get; set; }
        public string UaempFirstName { get; set; }
        public string UaempParName { get; set; }
        public string EmpInitials { get; set; }
        public string UaempInitials { get; set; }
        public byte EmpSex { get; set; }
        public int StockId { get; set; }
        public int PostId { get; set; }
        public string EmpBarCode { get; set; }
        public int? VaccinationId { get; set; }
        public bool? IsInvalid { get; set; }
    }
}
