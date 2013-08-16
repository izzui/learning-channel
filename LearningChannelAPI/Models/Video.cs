using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Models
{
	public class Video
	{
		public int Id { get; set; }
		public string Thumb { get; set; }
		public string Url { get; set; }
		public int LessonId { get; set; }
		public EnumProgress Progress { get; set; }
	}
}