using TrademarkLibrary.Model;

namespace TrademarkLibrary.Schema
{
    public class NZTrademarkType : GraphQL.Types.ObjectGraphType<NZTrademark>
    {
        public NZTrademarkType()
        {
            Name = "NZTrademark";
            Field(o => o.Id);
            Field(o => o.Name);
            Interface<TrademarkInterfaceType>();
            IsTypeOf = obj => obj is NZTrademark;
        }
    }

    public class NZTrademark : Trademark
    {
       
      
    }
}
