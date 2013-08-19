using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Data
{
	public class LearningChannelRepository : ILearningChannelRepository
	{
		LearningChannelContext _ctx;
		public LearningChannelRepository(LearningChannelContext ctx)
		{
			_ctx = ctx;
		}

		public IQueryable<Models.Topic> GetTopics()
		{
			return _ctx.Topics;
		}
	}
}