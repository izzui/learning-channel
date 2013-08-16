﻿using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LearningChannelAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "CourseItems",
				routeTemplate: "courses/{courseid}/{controller}"
			);

			config.Routes.MapHttpRoute(
				name: "UserItems",
				routeTemplate: "users/{userId}/{controller}"
			);
			

			// Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
			// To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
			// For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
			//config.EnableQuerySupport();

			// To disable tracing in your application, please comment out or remove the following line of code
			// For more information, refer to: http://www.asp.net/web-api
			var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
			config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

			var json = config.Formatters.JsonFormatter;
			json.SerializerSettings.ContractResolver =
				new CamelCasePropertyNamesContractResolver();

			json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented; 

			config.EnableSystemDiagnosticsTracing();
		}
	}
}
