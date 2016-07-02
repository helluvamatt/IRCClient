using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Microsoft.AspNet.SignalR;

namespace IRCClient.App_Start
{
	public class BundleConfig
	{
		public static void ConfigureBundles(BundleCollection bundles)
		{
			// Scripts
			bundles.Add(
				new ScriptBundle("~/assets/modernizr.js")
				.Include("~/Scripts/modernizr-{version}.js")
				);
			bundles.Add(
				new ScriptBundle("~/assets/app.js")
					.Include("~/Scripts/jquery-{version}.js")
					.Include("~/Scripts/jquery.signalR-{version}.js")
					.Include("~/Scripts/bootstrap.js")
					//.Include("~/Scripts/angular.js")
					//.Include("~/Scripts/angular-ui/ui-bootstrap.js")
					//.Include("~/Scripts/angular-ui/ui-bootstrap-tpls.js")
					//.Include("~/Scripts/app.js")
				);

			// Stylesheets
			bundles.Add(
				new StyleBundle("~/assets/app.css")
					.Include("~/Content/bootstrap.css")
					.Include("~/Content/bootstrap-theme.css")
					.Include("~/Content/font-awesome.css")
					//.Include("~/Content/ui-bootstrap-csp.css")
					.Include("~/Content/site.css")
				);
		}
	}
}