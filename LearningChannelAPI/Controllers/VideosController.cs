﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Controllers
{
	public class VideosController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public Video Get(int id)
		{
			return VideoDal.Videos.SingleOrDefault(v => v.Id == id);
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}
	}
}