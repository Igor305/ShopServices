using DataAccessLayer.AppContext;
using DataAccessLayer.Entities.Shops;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class ShopsRepository : IShopsRepository
    {
        private readonly ShopsContext _shopsContext;

        public ShopsRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }

        public async Task<List<Shop>> getAllShops()
        {
            List<Shop> shops = await _shopsContext.Shops.OrderBy(x=>x.ShopNumber).ToListAsync();

            return shops;
        }

        public async Task<Shop> getShopByShopNumber(int? shopNumber)
        {
            Shop shop = await _shopsContext.Shops.FirstOrDefaultAsync(x => x.ShopNumber == shopNumber && (x.StatusId == 6 || x.StatusId == 10 || x.StatusId == 14 || x.StatusId == 18 || x.StatusId == 22 || x.StatusId == 25));

            return shop;
        }

        public async Task<List<Shop>> getShopsByStatus(int statusId)
        {
            List<Shop> shops = await _shopsContext.Shops.OrderBy(x => x.ShopNumber).Where(x=>x.StatusId == statusId).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getAllStoresOpening()
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => x.OpenFrom != null && x.OpenFrom.Value > DateTime.Now && x.ShopNumber != null).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getStoresOpeningForMonth(DateTime from, DateTime till)
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => x.OpenFrom != null && x.OpenFrom.Value >= from && x.OpenFrom.Value <= till).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getQAPriority()
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => (x.OpenFrom != null && x.OpenFrom.Value > DateTime.Now && x.ShopNumber != null) || (x.QAPriorityTo != null && x.QAPriorityTo.Value > DateTime.Now && x.ShopNumber != null)).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getQAPriorityForMonth(DateTime from, DateTime till)
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => (x.OpenFrom != null && x.OpenFrom.Value >= from && x.OpenFrom.Value <= till) ||(x.QAPriorityTo != null && x.QAPriorityTo.Value >= from && x.QAPriorityTo.Value <= till)).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getShopsForTMS()
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => x.StatusId == 4 || x.StatusId == 8 || x.StatusId == 12 || x.StatusId == 16 || x.StatusId == 20 || x.StatusId == 25).OrderBy(x=>x.ShopNumber).ToListAsync();

            return shops;
        }

        public async Task<List<Shop>> getShopsForWorkTime()
        {
            List<Shop> shops = await _shopsContext.Shops.Where(x => x.StatusId == 6 || x.StatusId == 10 || x.StatusId == 14 || x.StatusId == 18 || x.StatusId == 22 || x.StatusId == 25).OrderBy(x => x.ShopNumber).ToListAsync();

            return shops;
        }
    }
}