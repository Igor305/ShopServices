using DataAccessLayer.AppContext;
using DataAccessLayer.Entities.Mobile;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class ReplicaStocksRepository : IReplicaStocksRepository
    {
        private readonly MobileContext _mobileContext;

        public ReplicaStocksRepository(MobileContext mobileContext)
        {
            _mobileContext = mobileContext;
        }

        public async Task<List<Stock1>> getDepotCode1()
        {
            List<Stock1> stocks = await _mobileContext.Stocks1.Where(x => x.DepotCode == 1).ToListAsync();

            return stocks;
        }

        public async Task<List<Stock1>> getDepotCode2()
        {
            List<Stock1> stocks = await _mobileContext.Stocks1.Where(x => x.DepotCode == 2).ToListAsync();

            return stocks;
        }
    }
}
