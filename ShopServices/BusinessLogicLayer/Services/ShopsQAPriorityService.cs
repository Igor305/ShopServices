using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities.Shops;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ShopsQAPriorityService : IShopsQAPriorityService
    {
        private readonly IShopsRepository _shopsRepository;
        public readonly IConfiguration _configuration;

        public ShopsQAPriorityService(IShopsRepository shopsRepository, IConfiguration configuration)
        {
            _shopsRepository = shopsRepository;
            _configuration = configuration;
        }

        public async Task<ShopsQAPriorityResponseModel> getQAPriority(string key)
        {
            ShopsQAPriorityResponseModel shopsQAPriorityResponseModel = new ShopsQAPriorityResponseModel();

            try
            {
                if (key != _configuration["Api:Key"])
                {
                    shopsQAPriorityResponseModel.Status = false;
                    shopsQAPriorityResponseModel.Message = "error key";

                    return shopsQAPriorityResponseModel;
                }

                List<Shop> shops = await _shopsRepository.getQAPriority();

                foreach (Shop shop in shops)
                {
                    if (shop.OpenFrom > DateTime.Now)
                    {
                        shopsQAPriorityResponseModel.shopQAPriorityModels.Add(new ShopQAPriorityModel { ShopNumber = shop.ShopNumber, OpenFrom = shop.OpenFrom });
                    }
                    if (shop.QAPriorityTo != null && shop.QAPriorityTo > DateTime.Now)
                    {
                        shopsQAPriorityResponseModel.shopQAPriorityModels.Add(new ShopQAPriorityModel { ShopNumber = shop.ShopNumber, OpenFrom = shop.QAPriorityTo });
                    }
                }

                shopsQAPriorityResponseModel.Status = true;
                shopsQAPriorityResponseModel.Message = "successfully";
            }
            catch (Exception e)
            {
                shopsQAPriorityResponseModel.Status = false;
                shopsQAPriorityResponseModel.Message = e.Message;
            }

            return shopsQAPriorityResponseModel;
        }
        public async Task<ShopsQAPriorityResponseModel> getQAPriorityForMonth(string key, DateTime from, DateTime till)
        {
            ShopsQAPriorityResponseModel shopsQAPriorityResponseModel = new ShopsQAPriorityResponseModel();

            try
            {

                if (key != _configuration["Api:Key"])
                {
                    shopsQAPriorityResponseModel.Status = false;
                    shopsQAPriorityResponseModel.Message = "error key";

                    return shopsQAPriorityResponseModel;
                }

                List<DateTime> dateTimes = check(from, till);

                List<Shop> shops = await _shopsRepository.getQAPriorityForMonth(dateTimes[0], dateTimes[1]);

                foreach (Shop shop in shops)
                {
                    if (shop.OpenFrom > DateTime.Now)
                    {
                        shopsQAPriorityResponseModel.shopQAPriorityModels.Add(new ShopQAPriorityModel { ShopNumber = shop.ShopNumber, OpenFrom = shop.OpenFrom });
                    }
                    if (shop.QAPriorityTo != null && shop.QAPriorityTo > DateTime.Now)
                    {
                        shopsQAPriorityResponseModel.shopQAPriorityModels.Add(new ShopQAPriorityModel { ShopNumber = shop.ShopNumber, OpenFrom = shop.QAPriorityTo });
                    }
                }

                shopsQAPriorityResponseModel.Status = true;
                shopsQAPriorityResponseModel.Message = "successfully";
            }
            catch (Exception e)
            {
                shopsQAPriorityResponseModel.Status = false;
                shopsQAPriorityResponseModel.Message = e.Message;
            }

            return shopsQAPriorityResponseModel;
        }

        private List<DateTime> check(DateTime from, DateTime till)
        {
            DateTime dateTime = new DateTime();

            List<DateTime> dateTimes = new List<DateTime>();

            if ((from == dateTime) && (till == dateTime))
            {

            }
            else
            {
                if (from == dateTime)
                {
                    from = DateTime.Now;
                }
                if (till == dateTime)
                {
                    till = new DateTime(9999, 9, 9);
                }
            }

            dateTimes.Add(from);
            dateTimes.Add(till);

            return dateTimes;
        }
    }
}
