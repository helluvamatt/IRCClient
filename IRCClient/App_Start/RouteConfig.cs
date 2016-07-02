using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace IRCClient.App_Start
{
	public class RouteConfig
	{
		public static void ConfigureRoutes(RouteCollection routes)
		{
			routes.MapMvcAttributeRoutes();

			routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Default", action = "Index", id = "" });
		}
	}
}