using DataAccessLayer.Entities.Shops;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IShopsRepository
    {
        public Task<List<Shop>> getAllShops();
        public Task<List<Shop>> getShopsByStatus(int statusId);
        public Task<List<Shop>> getAllStoresOpening();
        public Task<List<Shop>> getStoresOpeningForMonth(DateTime from, DateTime till);
        public Task<List<Shop>> getQAPriority();
        public Task<List<Shop>> getQAPriorityForMonth(DateTime from, DateTime till);
        public Task<List<Shop>> getShopsForTMS();
        public Task<List<Shop>> getShopsForWorkTime();
    }
}
