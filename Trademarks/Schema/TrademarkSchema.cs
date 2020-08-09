using GraphQL;

namespace TrademarkLibrary.Schema
{
    public class TrademarkSchema : GraphQL.Types.Schema
    {
        public TrademarkSchema(TrademarkQueryType trademarkQuery, IDependencyResolver resolver)
        {
            Query = trademarkQuery;            
            DependencyResolver = resolver;
            RegisterType<AUTrademarkType>();
            RegisterType<NZTrademarkType>();
        }
    }
}
