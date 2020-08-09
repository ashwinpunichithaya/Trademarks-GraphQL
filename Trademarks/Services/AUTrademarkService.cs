using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrademarkLibrary.Model;
using TrademarkLibrary.Schema;

namespace TrademarkLibrary.Services
{
    public class AUTrademarkService : ITrademarkService
    {
        private APIURLs _apiURLs;
        public AUTrademarkService(APIURLs apiURLs)
        {
            _apiURLs = apiURLs;
        }

        async Task<IEnumerable<Trademark>> getTrademarks(string title)
        {
            List<Trademark> trademarks = new List<Trademark>();
            RestClient client = new RestClient(_apiURLs.IPGOLD_API_URL);
            RestRequest request = new RestRequest() { Method = Method.GET, Resource = string.Format("action/datastore_search?resource_id=3c24ceeb-1035-49e9-bb5e-849df2a0a325&limit=20&q={0}", title) };
            IRestResponse result = await client.ExecuteAsync(request);
            dynamic jObject = JObject.Parse(result.Content);
            if ((bool)jObject.success)
            {
                foreach (var record in jObject.result.records)
                {
                    trademarks.Add(new AUTrademark()
                    {
                        Id = Guid.NewGuid().ToString("N"),
                        Name = Convert.ToString(record.trademark_text),
                        Number = Convert.ToString(record.tm_number)
                    });
                }
            }
            return trademarks;
        }

        public Task<IEnumerable<Trademark>> GetTrademarksAsync(string title)
        {
            return getTrademarks(title);
        }
    }
}
