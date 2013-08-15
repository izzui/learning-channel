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
		public Video[] Videos { get; set; }
	}
}