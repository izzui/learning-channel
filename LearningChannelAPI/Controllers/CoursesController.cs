using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Controllers
{
	public class CoursesController : ApiController
	{
		// GET api/<controller>
		[HttpGet]
		public IEnumerable<Course> List()
		{
			
			return new DataAccess.CourseDAL().List();
		}

		// GET api/<controller>/5
		public Course Get(int id)
		{	
			return new DataAccess.CourseDAL().Get(id);
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
			throw new InvalidOperationException();
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
			throw new InvalidOperationException();
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
			throw new InvalidOperationException();
		}
	}
}