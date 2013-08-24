using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Controllers
{
	public class AuthorsController : ApiController
	{
		[HttpGet]
		// GET course/5/<controller>
		public IEnumerable<Author> Get(int courseId)
		{
			var course = CourseDal.Courses.SingleOrDefault(c => c.Id == courseId);
			if (course == null)
				throw ApiException.CreateException(HttpStatusCode.NotFound, string.Format("Course {0} not found", courseId),
					"You must send a valid courseId.");
			if (course.Authors == null)
				throw ApiException.CreateException(HttpStatusCode.NotFound, string.Format("Course {0} has no authors", courseId),
					string.Format("Course {0} has no authors", courseId));
			return course.Authors;
		}

		//[HttpGet]
		//// GET api/<controller>/5
		//public string GetById(int id)
		//{
		//	return "value";
		//}

		//// POST api/<controller>
		//public void Post([FromBody]string value)
		//{
		//}

		//// PUT api/<controller>/5
		//public void Put(int id, [FromBody]string value)
		//{
		//}

		//// DELETE api/<controller>/5
		//public void Delete(int id)
		//{
		//}
	}
}