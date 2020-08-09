using GraphQL.Types;
using TrademarkLibrary.Model;

namespace TrademarkLibrary.Schema
{
    public class TrademarkType : ObjectGraphType<Trademark>
    {
        public TrademarkType()
        {
            Name = "Trademark";

            Field(t => t.Id);
            Field(t => t.Name);
        }
    }
}
