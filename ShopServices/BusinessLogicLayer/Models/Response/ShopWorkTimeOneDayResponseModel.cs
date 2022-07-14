using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class ShopWorkTimeOneDayResponseModel
    {
        /// <summary>
        /// Робочі години магазинів
        /// </summary>
        public List<ShopWorkTimeOneDayModel> workTimes { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Текст помилки
        /// </summary>
        public string Message { get; set; }

        public ShopWorkTimeOneDayResponseModel()
        {
            workTimes = new List<ShopWorkTimeOneDayModel>();
        }
    }
}
