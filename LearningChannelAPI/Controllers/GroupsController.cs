using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Controllers
{
	public class GroupsController : ApiController
	{
		[HttpGet]
		// GET courses/5/<controller>
		public IEnumerable<Group> Get(int courseId)
		{
			return GroupsDal.Groups.Where(x => x.CourseId == courseId);
		}

		//[HttpGet]
		//// GET api/<controller>/5
		//public string GetByid(int id)
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