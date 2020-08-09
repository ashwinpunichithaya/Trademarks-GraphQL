using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrademarkLibrary.Model;
using TrademarkLibrary.Services;

namespace TrademarkLibrary.Schema
{
    public class TrademarkQueryType : ObjectGraphType<object>
    {
        public TrademarkQueryType(IServiceProvider serviceProvider)
        {
            Name = "Query";
            Field<ListGraphType<TrademarkInterfaceType>>("trademarks",
                arguments: new QueryArguments(new QueryArgument<StringGraphType>() { Name = "title" }),
                resolve: context =>
                {
                    var title = context.GetArgument<string>("title");
                    var trademarkServices = serviceProvider.GetServices<ITrademarkService>();
                    var result = new List<Trademark>();
                    Parallel.ForEach(trademarkServices, (trademarkService) =>
                    {
                        result.AddRange(trademarkService.GetTrademarksAsync(title).Result);
                    });
                    return result; 
                });
        }
    }
}
