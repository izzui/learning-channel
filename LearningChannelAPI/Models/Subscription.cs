using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Subscription
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int CourseId { get; set; }
	}
}