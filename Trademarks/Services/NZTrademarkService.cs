using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrademarkLibrary.Model;
using TrademarkLibrary.Schema;
using IPONZTS = TrademarkLibrary.DTO.IPONZ.TS;

namespace TrademarkLibrary.Services
{
    public class NZTrademarkService : ITrademarkService
    {
        private APIURLs _apiURLs;
        public NZTrademarkService(APIURLs apiURLs)
        {
            _apiURLs = apiURLs;
        }

        async Task<IEnumerable<Trademark>> getTrademarks(string title)
        {
            List<Trademark> listTrademarks = new List<Trademark>();
            RestClient client = new RestClient(_apiURLs.IPONZ_API_URL);
            RestRequest request = new RestRequest("/TradeMarkSearch", Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("soapaction", "ListTrademarks");
            request.AddHeader("content-type", "text/xml;charset=UTF-8");
            request.AddHeader("authorization", "Bearer 1a3adf01fad59391a03c7497c059735a");
            IPONZTS.RequestTypes.Envelope envelope = new IPONZTS.RequestTypes.Envelope()
            {
                Body = new IPONZTS.RequestTypes.EnvelopeBody()
                {
                    ListTrademarks = new IPONZTS.RequestTypes.ListTrademarksRequest()
                    {
                        ListTradeMarks = new IPONZTS.RequestTypes.ListTradeMarks()
                        {
                            ListTradeMarksBody = new IPONZTS.RequestTypes.ListTrademarksBody()
                            {
                                ListTradeMarksContentDetails = new IPONZTS.RequestTypes.ListTradeMarksContentDetails()
                                {
                                    TradeMarkSearchCriteria = new IPONZTS.RequestTypes.TrademarkSearchCriteria()
                                    {
                                        StatusList = new ushort[] { 5, 6, 7, 8, 12, 13, 165, 166, 1012, 1013, 1015, 1016, 1017 },
                                        Title = title
                                    }
                                }
                            }
                        }
                    }
                }
            };

            DotNetXmlSerializer serializer = new DotNetXmlSerializer();
            string requestbody = serializer.Serialize(envelope);
            request.AddParameter("text/xml;charset=UTF-8", requestbody, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            DotNetXmlDeserializer deserializer = new DotNetXmlDeserializer();
            IPONZTS.ResponseTypes.Envelope trademarkResponse = deserializer.Deserialize<IPONZTS.ResponseTypes.Envelope>(response);
            IPONZTS.ResponseTypes.ListTMsResponse listTMsResponse = trademarkResponse.Body.ListTrademarksResponse.ListTMsResponse;
            if (listTMsResponse != null && !listTMsResponse.faultErrorEncountered && !listTMsResponse.appErrorEncountered)
            {
                var trademarks = listTMsResponse.ListTradeMarksResponse.ListTradeMarksResponseBody.ListTradeMarksResponseContentDetails.ListTradeMarksResponseData.TradeMarks;
                if (trademarks != null)
                {
                    foreach (var trademark in trademarks.Take(20))
                    {
                        listTrademarks.Add(new NZTrademark()
                        {
                            Id = trademark.ApplicationNumber.ToString(),
                            Name = trademark.MarkTitle
                        });
                    }
                }

            }
            return listTrademarks;
        }

        public Task<IEnumerable<Trademark>> GetTrademarksAsync(string title)
        {
            return getTrademarks(title);
        }
    }
}
