using BusinessLogicLayer.Models.Response;
using System;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IShopsQAPriorityService
    {
        public Task<ShopsQAPriorityResponseModel> getQAPriorityDepotCode1(string key);
        public Task<ShopsQAPriorityResponseModel> getQAPriorityDepotCode2(string key);
        public Task<ShopsQAPriorityResponseModel> getQAPriorityForMonth(string key, DateTime from, DateTime till);
    }
}
