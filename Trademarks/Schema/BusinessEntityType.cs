using TrademarkLibrary.Model;

namespace TrademarkLibrary.Schema
{
    public class BusinessEntityType : GraphQL.Types.ObjectGraphType<BusinessEntity>
    {
        public BusinessEntityType()
        {
            Name = "BusinessEntity";
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Location);
            Field(o => o.TrademarkNumber);
        }
    }
}
