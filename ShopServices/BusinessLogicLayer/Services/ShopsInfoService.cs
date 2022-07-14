﻿using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities.Exchange;
using DataAccessLayer.Entities.Shops;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ShopsInfoService : IShopsInfoService
    {
        private readonly IShopsRepository _shopsRepository;
        private readonly IRegionsLocalizationRepository _regionsLocalizationRepository;
        private readonly IDistrictsLocalizationRepository _districtsLocalizationRepository;
        private readonly ICitiesLocalizationRepository _citiesLocalizationRepository;
        private readonly IStreetsLocalizationRepository _streetsLocalizationRepository;
        private readonly IShopRegionLocalizationRepository _shopRegionLocalizationRepository;
        private readonly IEmployeesDirectoryRepository _employeesDirectoryRepository;
        private readonly IShopWorkTimesRepository _shopWorkTimesRepository;

        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ShopsInfoService(IShopsRepository shopsRepository, IRegionsLocalizationRepository regionsLocalizationRepository, IDistrictsLocalizationRepository districtsLocalizationRepository,
                                IShopRegionLocalizationRepository shopRegionLocalizationRepository, ICitiesLocalizationRepository citiesLocalizationRepository, IStreetsLocalizationRepository streetsLocalizationRepository,
                                IEmployeesDirectoryRepository employeesDirectoryRepository, IShopWorkTimesRepository shopWorkTimesRepository, IMapper mapper, IConfiguration configuration)
        {
            _shopsRepository = shopsRepository;
            _regionsLocalizationRepository = regionsLocalizationRepository;
            _districtsLocalizationRepository = districtsLocalizationRepository;
            _citiesLocalizationRepository = citiesLocalizationRepository;
            _streetsLocalizationRepository = streetsLocalizationRepository;
            _shopRegionLocalizationRepository = shopRegionLocalizationRepository;
            _employeesDirectoryRepository = employeesDirectoryRepository;
            _shopWorkTimesRepository = shopWorkTimesRepository;

            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ShopsInfoResponseModel> getInfoForAllShops(string key)
        {
            ShopsInfoResponseModel shopsInfoResponseModel = new ShopsInfoResponseModel();

            if (key != _configuration["Api:Key"])
            {
                shopsInfoResponseModel.Status = false;
                shopsInfoResponseModel.Message = "error key";
                return shopsInfoResponseModel;
            }

            try
            {
                List<Shop> shops = await _shopsRepository.getAllShops();
                await getShops(shops, shopsInfoResponseModel);
            }

            catch (Exception e)
            {
                shopsInfoResponseModel.Status = false;
                shopsInfoResponseModel.Message = e.Message;
            }

            return shopsInfoResponseModel;
        }

        public async Task<ShopsInfoResponseModel> getInfoForShopsByStatus(string key, int statusId)
        {
            ShopsInfoResponseModel shopsInfoResponseModel = new ShopsInfoResponseModel();

            if (key != _configuration["Api:Key"])
            {
                shopsInfoResponseModel.Status = false;
                shopsInfoResponseModel.Message = "error key";
                return shopsInfoResponseModel;
            }

            try
            {
                List<Shop> shops = await _shopsRepository.getShopsByStatus(statusId);
                await getShops(shops, shopsInfoResponseModel);
            }
            catch (Exception e)
            {
                shopsInfoResponseModel.Status = false;
                shopsInfoResponseModel.Message = e.Message;
            }

            return shopsInfoResponseModel;
        }
        
        private async Task getShops(List<Shop> shops, ShopsInfoResponseModel shopsInfoResponseModel)
        {
            List<RegionsLocalization> regionsLocalizations = await _regionsLocalizationRepository.getAll();
            List<DistrictsLocalization> districtsLocalizations = await _districtsLocalizationRepository.getAll();
            List<CitiesLocalization> citiesLocalizations = await _citiesLocalizationRepository.getAll();
            List<StreetsLocalization> streetsLocalizations = await _streetsLocalizationRepository.getAll();
            List<ShopRegionLocalization> shopRegionLocalizations = await _shopRegionLocalizationRepository.getAll();
            List<EmployeesDirectory> employeesDirectories = await _employeesDirectoryRepository.getAll();

            List<ShopModel> shopModels = _mapper.Map<List<Shop>, List<ShopModel>>(shops);
            List<RegionsLocalizationModel> regionsLocalizationModels = _mapper.Map<List<RegionsLocalization>, List<RegionsLocalizationModel>>(regionsLocalizations);
            List<DistrictsLocalizationModel> districtsLocalizationModels = _mapper.Map<List<DistrictsLocalization>, List<DistrictsLocalizationModel>>(districtsLocalizations);
            List<CitiesLocalizationModel> citiesLocalizationModels = _mapper.Map<List<CitiesLocalization>, List<CitiesLocalizationModel>>(citiesLocalizations);
            List<StreetsLocalizationModel> streetsLocalizationModels = _mapper.Map<List<StreetsLocalization>, List<StreetsLocalizationModel>>(streetsLocalizations);
            List<ShopRegionLocalizationModel> shopRegionLocalizationModels = _mapper.Map<List<ShopRegionLocalization>, List<ShopRegionLocalizationModel>>(shopRegionLocalizations);
            List<EmployeesDirectoryModel> employeesDirectoryModels = _mapper.Map<List<EmployeesDirectory>, List<EmployeesDirectoryModel>>(employeesDirectories);

            foreach (ShopModel shopModel in shopModels)
            {
                ShopInfoModel shopInfoModel = new ShopInfoModel();

                shopInfoModel.ShopNumber = shopModel.ShopNumber;
                shopInfoModel.StatusId = shopModel.StatusId;
                shopInfoModel.Address = shopModel.Address;
                shopInfoModel.AddressComment = shopModel.AddressComment;
                shopInfoModel.Latitude = shopModel.Latitude;
                shopInfoModel.Longitude = shopModel.Longitude;
                shopInfoModel.ShopWorkTimeString = shopModel.ShopWorkTimeString;
                shopInfoModel.WorkPhoneNumber = shopModel.WorkPhoneNumber;

                foreach (RegionsLocalizationModel regionsLocalizationModel in regionsLocalizationModels)
                {
                    if (regionsLocalizationModel.RegionId == shopModel.RegionId && regionsLocalizationModel.LanguageId == 2)
                    {
                        shopInfoModel.Region = regionsLocalizationModel.Name;
                    }
                }

                foreach (DistrictsLocalizationModel districtsLocalizationModel in districtsLocalizationModels)
                {
                    if (districtsLocalizationModel.DistrictId == shopModel.RegionId && districtsLocalizationModel.LanguageId == 2)
                    {
                        shopInfoModel.District = districtsLocalizationModel.Name;
                    }
                }

                foreach (CitiesLocalizationModel citiesLocalizationModel in citiesLocalizationModels)
                {
                    if (citiesLocalizationModel.CityId == shopModel.CityId && citiesLocalizationModel.LanguageId == 2)
                    {
                        shopInfoModel.City = citiesLocalizationModel.Name;
                    }
                }

                foreach (StreetsLocalizationModel streetsLocalizationModel in streetsLocalizationModels)
                {
                    if (streetsLocalizationModel.StreetId == shopModel.StreetId && streetsLocalizationModel.LanguageId == 2)
                    {
                        shopInfoModel.Street = streetsLocalizationModel.Name;
                    }
                }

                foreach (ShopRegionLocalizationModel shopRegionLocalizationModel in shopRegionLocalizationModels)
                {
                    if (shopRegionLocalizationModel.ShopRegionId == shopModel.ShopRegionId && shopRegionLocalizationModel.LanguageId == 2)
                    {
                        shopInfoModel.ShopRegion = shopRegionLocalizationModel.Name;
                    }
                }

                foreach (EmployeesDirectoryModel employeesDirectoryModel in employeesDirectoryModels)
                {
                    if (shopModel.TerritorialManagerId != null && employeesDirectoryModel.Idrref.SequenceEqual(shopModel.TerritorialManagerId))
                    {
                        shopInfoModel.TerritorialManager = employeesDirectoryModel.FullName;
                    }

                    if (shopModel.RegionalManagerId != null && employeesDirectoryModel.Idrref.SequenceEqual(shopModel.RegionalManagerId))
                    {
                        shopInfoModel.RegionalManager = employeesDirectoryModel.FullName;
                    }

                    if (shopModel.AdministratorId != null && employeesDirectoryModel.Idrref.SequenceEqual(shopModel.AdministratorId))
                    {
                        shopInfoModel.Administrator = employeesDirectoryModel.FullName;
                    }

                    if (shopModel.DeputyAdministratorId != null && employeesDirectoryModel.Idrref.SequenceEqual(shopModel.DeputyAdministratorId))
                    {
                        shopInfoModel.DeputyAdministrator = employeesDirectoryModel.FullName;
                    }
                }

                shopsInfoResponseModel.shopInfoModels.Add(shopInfoModel);
            }

            shopsInfoResponseModel.Status = true;
            shopsInfoResponseModel.Message = "successfully";
        }

        public async Task<ShopWorkTimeOneDayResponseModel> getShopsForWorkTime(string key,DateTime date, int? shopNumber)
        {
            ShopWorkTimeOneDayResponseModel shopWorkTimeOneDayResponseModel = new ShopWorkTimeOneDayResponseModel();

            if (key != _configuration["Api:Key"])
            {
                shopWorkTimeOneDayResponseModel.Status = false;
                shopWorkTimeOneDayResponseModel.Message = "error key";
                return shopWorkTimeOneDayResponseModel;
            }

            try
            {
                DayOfWeek dayOfWeek = date.DayOfWeek;

                List<ShopWorkTime> shopWorkTimes = await _shopWorkTimesRepository.getTimes();
                List<ShopWorkTimeModel> shopWorkTimeModels = _mapper.Map<List<ShopWorkTime>, List<ShopWorkTimeModel>>(shopWorkTimes);

                if (shopNumber == null)
                {
                    List<Shop> shops = await _shopsRepository.getShopsForWorkTime();
                    List<ShopModel> shopsModel = _mapper.Map<List<Shop>, List<ShopModel>>(shops);

                    foreach (ShopModel shopModel in shopsModel)
                    {
                        getWorkTime(shopWorkTimeModels, shopModel, dayOfWeek,shopWorkTimeOneDayResponseModel);
                    }
                }

                if (shopNumber != null)
                {
                    Shop shop = await _shopsRepository.getShopByShopNumber(shopNumber);

                    if (shop == null)
                    {
                        shopWorkTimeOneDayResponseModel.Status = true;
                        shopWorkTimeOneDayResponseModel.Message = "The specified store number does not exist";
                        return shopWorkTimeOneDayResponseModel;
                    }

                    if (shop != null)
                    {
                        ShopModel shopModel = _mapper.Map<Shop, ShopModel>(shop);
                        getWorkTime(shopWorkTimeModels, shopModel, dayOfWeek, shopWorkTimeOneDayResponseModel);
                    }
                  
                }

                shopWorkTimeOneDayResponseModel.Status = true;
                shopWorkTimeOneDayResponseModel.Message = "successfully";
            }
            catch
            {

            }
            return shopWorkTimeOneDayResponseModel;
        }

        private void getWorkTime(List<ShopWorkTimeModel> shopWorkTimeModels, ShopModel shopModel, DayOfWeek dayOfWeek, ShopWorkTimeOneDayResponseModel shopWorkTimeOneDayResponseModel)
        {
            foreach (ShopWorkTimeModel shopWorkTimeModel in shopWorkTimeModels)
            {
                if (shopModel.ShopWorkTimeId == shopWorkTimeModel.Id)
                {
                    ShopWorkTimeOneDayModel shopWorkTimeOneDayModel = new ShopWorkTimeOneDayModel();
                    shopWorkTimeOneDayModel.ShopNumber = shopModel.ShopNumber;

                    switch (dayOfWeek)
                    {
                        case DayOfWeek.Sunday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.SundayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.SundayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Monday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.MondayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.MondayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Tuesday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.TuesdayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.TuesdayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Wednesday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.WednesdayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.WednesdayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Thursday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.ThursdayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.ThursdayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Friday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.FridayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.FridayTo.ToLongTimeString();
                            }
                            break;
                        case DayOfWeek.Saturday:
                            {
                                shopWorkTimeOneDayModel.From = shopWorkTimeModel.SaturdayFrom.ToLongTimeString();
                                shopWorkTimeOneDayModel.To = shopWorkTimeModel.SaturdayTo.ToLongTimeString();
                            }
                            break;
                    }

                    shopWorkTimeOneDayResponseModel.workTimes.Add(shopWorkTimeOneDayModel);
                }
            }
        }
    }
}
