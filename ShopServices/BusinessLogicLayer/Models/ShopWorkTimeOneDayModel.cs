using System;

namespace BusinessLogicLayer.Models
{
    public class ShopWorkTimeOneDayModel
    {
        /// <summary>
        /// Номер магазину
        /// </summary>
        public int? ShopNumber { get; set; }
        /// <summary>
        /// Час відкриття
        /// </summary>
        public string From { get; set; }
        /// <summary>
        ///  Час закриття
        /// </summary>
        public string To { get; set; }
    }
}
