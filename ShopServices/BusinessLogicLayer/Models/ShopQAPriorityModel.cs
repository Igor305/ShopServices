using System;

namespace BusinessLogicLayer.Models
{
    public class ShopQAPriorityModel
    {
        /// <summary>
        /// Номер ТТ
        /// </summary>
        public int? ShopNumber { get; set; }
        /// <summary>
        /// Дата відкриття
        /// </summary>
        public DateTime? OpenFrom { get; set; }
    }
}
