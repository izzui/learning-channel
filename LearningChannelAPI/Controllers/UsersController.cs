using LearningChannelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.DataAccess;

namespace LearningChannelAPI.Controllers
{
	public class UsersController : ApiController
	{
		[HttpGet]
		public User Get(string id)
		{
			return null;
		}

		//[HttpPost]
		//public void Post([FromBody] string value)
		//{

		//}
	}
}