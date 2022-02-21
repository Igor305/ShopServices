using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class qaPriorityController : ControllerBase
    {
        private readonly IShopsQAPriorityService _shopsQAPriorityService;

        public qaPriorityController(IShopsQAPriorityService shopsQAPriorityService)
        {
            _shopsQAPriorityService = shopsQAPriorityService;
        }

        /// <summary>
        /// Реєстр магазинів для відображення QA
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://shop-services.avrora.lan/api/qaPriority?key=exampleKey
        ///
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        public async Task<ShopsQAPriorityResponseModel> getAllStoresOpening([FromQuery] string key)
        {
            ShopsQAPriorityResponseModel shopsQAPriorityResponseModel = await _shopsQAPriorityService.getQAPriority(key);

            return shopsQAPriorityResponseModel;
        }
        /// <summary>
        /// Реєстр магазинів для відображення QA у періоді
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <param name="from">Початкова дата</param>
        /// <param name="till">Кінцева дата</param>
        /// <remarks>
        /// Sample request:
        ///
        ///     http://shop-services.avrora.lan/api/qaPriority/period?key=exampleKey&amp;from=2021-09-28
        ///
        /// </remarks>
        /// <returns></returns>
        [HttpGet("period")]
        public async Task<ShopsQAPriorityResponseModel> getAllStoresOpening([FromQuery] string key, [FromQuery] DateTime from, [FromQuery] DateTime till)
        {
            ShopsQAPriorityResponseModel shopsQAPriorityResponseModel = await _shopsQAPriorityService.getQAPriorityForMonth(key, from, till);

            return shopsQAPriorityResponseModel;
        }
    }
}
