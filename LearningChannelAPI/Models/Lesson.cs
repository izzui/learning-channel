using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Lesson
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public ICollection<Video> Videos { get; set; }
		public int CourseId { get; set; }
		public int Order { get; set; }
	}
}