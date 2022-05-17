using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class qaPriorityDcvController : ControllerBase
    {
        private readonly IShopsQAPriorityService _shopsQAPriorityService;

        public qaPriorityDcvController(IShopsQAPriorityService shopsQAPriorityService)
        {
            _shopsQAPriorityService = shopsQAPriorityService;
        }

        /// <summary>
        /// Реєстр магазинів для відображення QA, DepotCode = 2
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://shop-services.avrora.lan/api/qaPriorityDcv?key=exampleKey
        ///
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        public async Task<ShopsQAPriorityResponseModel> getAllStoresOpening([FromQuery] string key)
        {
            ShopsQAPriorityResponseModel shopsQAPriorityResponseModel = await _shopsQAPriorityService.getQAPriorityDepotCode2(key);

            return shopsQAPriorityResponseModel;
        }
    }
}
