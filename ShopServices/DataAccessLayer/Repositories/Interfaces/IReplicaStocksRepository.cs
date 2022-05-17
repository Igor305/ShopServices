using DataAccessLayer.Entities.Mobile;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IReplicaStocksRepository
    {
        public Task<List<Stock1>> getDepotCode1();
        public Task<List<Stock1>> getDepotCode2();
    }
}
