using LearningChannelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningChannelAPI.Data
{
	public interface ILearningChannelRepository
	{
		IQueryable<Topic> GetTopics();
	}
}
