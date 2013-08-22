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
		public ICollection<VideoSource> Sources { get; set; }
		public string Title { get; set; }
		public EnumProgress Progress { get; set; }
		public int NextId { get; set; }
		public int PreviousId { get; set; }
		public int LessonId { get; set; }
		public int Order { get; set; }
		
	}
}