using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class ShopsInfoResponseModel
    {
        public List<ShopInfoModel> shopInfoModels { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Текст помилки
        /// </summary>
        public string Message { get; set; }

        public ShopsInfoResponseModel()
        {
            shopInfoModels = new List<ShopInfoModel>();
        }
    }
}
