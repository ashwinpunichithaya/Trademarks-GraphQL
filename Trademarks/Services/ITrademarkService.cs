using System.Collections.Generic;
using System.Threading.Tasks;
using TrademarkLibrary.Model;

namespace TrademarkLibrary.Services
{
    public interface ITrademarkService
    {
        Task<IEnumerable<Trademark>> GetTrademarksAsync(string title);        
    }
}
