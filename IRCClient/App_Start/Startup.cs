using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;
using System.Web.Optimization;

[assembly: OwinStartup(typeof(IRCClient.App_Start.Startup))]
namespace IRCClient.App_Start
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// Configure SignalR
			app.MapSignalR();

			// Configure WebAPI 2
			var httpConfig = new HttpConfiguration();
			WebApiConfig.Register(httpConfig);
			app.UseWebApi(httpConfig);

			// Configure bundles
			BundleConfig.ConfigureBundles(BundleTable.Bundles);

			// Configure MVC 5
			RouteConfig.ConfigureRoutes(RouteTable.Routes);
		}
	}
}