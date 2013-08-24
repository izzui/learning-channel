using System.Linq;
using System.Net;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Controllers
{
	public class LessonsController : ApiController
	{
		//// GET api/<controller>
		//public IEnumerable<string> Get()
		//{
		//	return new string[] { "value1", "value2" };
		//}

		// GET api/<controller>/5
		public Lesson Get(int id)
		{
			Lesson lesson = LessonDal.Lessons.SingleOrDefault(l => l.Id == id);
			if (lesson == null)
			{
				throw ApiException.CreateException(HttpStatusCode.NotFound, string.Format("Course {0} not found", id),
					string.Format("Course {0} not found", id));
			}
			return lesson;
		}

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