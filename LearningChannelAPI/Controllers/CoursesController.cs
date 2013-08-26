using System.Linq;
using System.Net;
using System.Net.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Controllers
{
	public class CoursesController : ApiController
	{

		private Dictionary<string, object> DefaultValues
		{
			get
			{
				var valuesDictionary = new Dictionary<string, object>();
				valuesDictionary["language"] = Languages.AllLanguages;
				valuesDictionary["sort"] = CoursesSorter.Title;
				valuesDictionary["pageNumber"] = 1;
				valuesDictionary["pageSize"] = 3;
				return valuesDictionary;
			}
		}


		// GET <controller>
		/// <summary>
		/// Get a Course List filtered by language, sorted and paginated
		/// </summary>
		/// <param name="lang">All_Languages, en, pt, es</param>
		/// <param name="title, views, subscriptions, publishdate"></param>
		/// <example>https://learningchannelapi.izzui.com/Courses?lang=All_Languages&sort=Title&pagesize=3&pagenumber=1</example>
		/// <returns></returns>
		[HttpGet]
		public IEnumerable<Course> List()
		{

			if (Request.RequestUri.ParseQueryString().Get("pagenumber") == string.Empty)
			{
				throw ApiException.CreateException(HttpStatusCode.BadRequest, "PageNumber is empty",
					"You must enter a value for the pagenumber, or not send this parameter");
			}
			string language = Request.RequestUri.ParseQueryString().Get("lang") ?? DefaultValues["language"].ToString();
			string sort = Request.RequestUri.ParseQueryString().Get("sort") ?? DefaultValues["sort"].ToString();
			int pageNumber = Request.RequestUri.ParseQueryString().Get("pagenumber") == null ? (int)DefaultValues["pageNumber"] : Convert.ToInt32(Request.RequestUri.ParseQueryString().Get("pagenumber"));
			int pageSize = Request.RequestUri.ParseQueryString().Get("pagesize") == null ? (int)DefaultValues["pageSize"] : Convert.ToInt32(Request.RequestUri.ParseQueryString().Get("pagesize"));
			bool popular = Request.RequestUri.ParseQueryString().Get("popular") == null ? false : bool.Parse(Request.RequestUri.ParseQueryString().Get("popular"));

				return new DataAccess.CourseDal().List(language, pageNumber, pageSize, sort).ToArray();
		}

		[HttpGet]
		// GET <controller>/5
		public Course Get(int id)
		{
			var course = CourseDal.Courses.Single(c => c.Id == id);
			if (course == null)
				throw ApiException.CreateException(HttpStatusCode.NotFound, string.Format("Course {0} not found", id),
					string.Format("Course {0} not found", id));
			return course;
		}

		[HttpGet]
		public IEnumerable<Course> List(string userId)
		{
			return CourseDal.Courses.Where(c => SubscriptionDal.Subscriptions.Any(s => s.CourseId == c.Id));
		}

		//[HttpPost]
		//// POST <controller>
		//public void Post([FromBody]string value)
		//{
		//	throw new HttpResponseException(HttpStatusCode.NotImplemented);
		//}

		//[HttpPut]
		//// PUT <controller>/5
		//public void Put(int id, [FromBody]string value)
		//{
		//	throw new HttpResponseException(HttpStatusCode.NotImplemented);
		//}

		//[HttpDelete]
		//// DELETE <controller>/5
		//public void Delete(int id)
		//{
		//	throw new HttpResponseException(HttpStatusCode.NotImplemented);
		//}
	}
}