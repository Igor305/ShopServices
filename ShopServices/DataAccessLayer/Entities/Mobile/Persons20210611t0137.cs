using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Mobile
{
    public partial class Persons20210611t0137
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string BarCode { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int State { get; set; }
        public byte Sex { get; set; }
        public string FactCity { get; set; }
        public DateTime? FillingDate { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
}
