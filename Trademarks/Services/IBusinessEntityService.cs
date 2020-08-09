using System.Collections.Generic;
using System.Threading.Tasks;
using TrademarkLibrary.Model;

namespace TrademarkLibrary.Services
{
    public interface IBusinessEntityService
    {
        Task<IEnumerable<BusinessEntity>> GetBusinessEntitiesByTrademarkAsync(string trademarkNumber);
    }
}
