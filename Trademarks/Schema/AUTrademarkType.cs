using GraphQL.Types;
using TrademarkLibrary.Model;
using TrademarkLibrary.Services;

namespace TrademarkLibrary.Schema
{
    public class AUTrademarkType : GraphQL.Types.ObjectGraphType<AUTrademark>
    {
        public AUTrademarkType(IBusinessEntityService businessEntityService)
        {
            Name = "AUTrademark";
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Number);
            Field<ListGraphType<BusinessEntityType>>("entities", resolve: context => businessEntityService.GetBusinessEntitiesByTrademarkAsync(context.Source.Number));
            Interface<TrademarkInterfaceType>();
            IsTypeOf = obj => obj is AUTrademark;
        }
    }

    public class AUTrademark : Trademark
    {
        public string Number { get; set; }
    }
}
