using TrademarkLibrary.Model;

namespace TrademarkLibrary.Schema
{
    public class TrademarkInterfaceType : GraphQL.Types.InterfaceGraphType<Trademark>
    {
        public TrademarkInterfaceType()
        {
            Name = "Trademark";
            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}
