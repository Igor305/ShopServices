using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string BarCode { get; set; }
    }
}
