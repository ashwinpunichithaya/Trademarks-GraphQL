using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrademarkLibrary.Model;

namespace TrademarkLibrary.Services
{
    public class BusinessEntityService : IBusinessEntityService
    {
        private APIURLs _apiURLs;
        public BusinessEntityService(APIURLs apiURLs)
        {
            _apiURLs = apiURLs;
        }

        async Task<IEnumerable<BusinessEntity>> getBusinessEntitiesByTrademark(string trademarkNumber)
        {
            List<BusinessEntity> entities = new List<BusinessEntity>();
            RestClient client = new RestClient(_apiURLs.IPGOLD_API_URL);
            RestRequest request = new RestRequest() { Method = Method.GET, Resource = string.Format("action/datastore_search_sql?sql=SELECT * from \"aae1c14d-f8c0-4540-b5d3-1ed21500271e\" WHERE tm_number = '{0}'", trademarkNumber) };
            IRestResponse result = await client.ExecuteAsync(request);
            dynamic jObject = JObject.Parse(result.Content);
            if ((bool)jObject.success)
            {
                foreach (var record in jObject.result.records)
                {
                    entities.Add(new BusinessEntity()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Name = Convert.ToString(record.name),
                        Location = Convert.ToString(record.country),
                        TrademarkNumber = trademarkNumber
                    });
                }
            }
            return entities;
        }

        public Task<IEnumerable<BusinessEntity>> GetBusinessEntitiesByTrademarkAsync(string trademarkNumber)
        {
            return getBusinessEntitiesByTrademark(trademarkNumber);
        }
    }
}
