using GraphQL;
using GraphQL.Server.Transports.AspNetCore;
using GraphQL.Server.Transports.WebSockets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrademarkLibrary;
using TrademarkLibrary.Schema;
using TrademarkLibrary.Services;

namespace Server
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            APIURLs apiURLs = new APIURLs() {
                IPGOLD_API_URL = Configuration.GetValue<string>("APIURLs:IPGOLD_API_URL"),
                IPONZ_API_URL = Configuration.GetValue<string>("APIURLs:IPONZ_API_URL")
            };
            services.AddSingleton(apiURLs);
            services.AddSingleton<BusinessEntityType>();
            services.AddSingleton<IBusinessEntityService, BusinessEntityService>();
            services.AddSingleton<TrademarkInterfaceType>();            
            services.AddSingleton<AUTrademarkType>();
            services.AddSingleton<NZTrademarkType>();
            services.AddSingleton<TrademarkQueryType>();
            services.AddSingleton<TrademarkSchema>();
            services.AddSingleton<ITrademarkService, AUTrademarkService>();
            services.AddSingleton<ITrademarkService, NZTrademarkService>();
            services.AddSingleton<IDependencyResolver>(
                c => new FuncDependencyResolver(type => c.GetRequiredService(type)));
            services.AddGraphQLHttp();
            services.AddGraphQLWebSocket<TrademarkSchema>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseWebSockets();
            app.UseGraphQLWebSocket<TrademarkSchema>(new GraphQLWebSocketsOptions());
            app.UseGraphQLHttp<TrademarkSchema>(new GraphQLHttpOptions());
        }
    }
}
