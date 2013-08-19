using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;
using LearningChannelAPI.Data;

namespace LearningChannelAPI.Controllers
{
	public class TopicsController : ApiController
	{
		private ILearningChannelRepository _repo;

		public TopicsController(ILearningChannelRepository repo)
		{
			_repo = repo;
		}
		// GET api/<controller>
		public IEnumerable<Topic> Get()
		{
			return _repo.GetTopics().ToArray();
		}

		// GET api/<controller>/5
		public Topic Get(int id)
		{

			Topic topic = TopicDal.Topics.SingleOrDefault(t => t.Id == id);
			if (topic == null)
				throw ApiException.CreateException(HttpStatusCode.NotFound, string.Format("Topic {0} not found", id),
					string.Format("Topic {0} not found", id));
			return topic;
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