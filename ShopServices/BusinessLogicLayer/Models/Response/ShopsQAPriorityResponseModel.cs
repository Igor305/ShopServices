using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class ShopsQAPriorityResponseModel
    {
        public List<ShopQAPriorityModel> shopQAPriorityModels { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Текст помилки
        /// </summary>
        public string Message { get; set; }

        public ShopsQAPriorityResponseModel()
        {
            shopQAPriorityModels = new List<ShopQAPriorityModel>();
        }
    }
}
