using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Models
{
	public class Video
	{
		public int Id { get; set; }
		public int LessonId { get; set; }
		public string Thumb { get; set; }
		public ICollection<VideoSource> Sources { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public string Url { get; set; }
		public EnumProgress Progress { get; set; }
		public int Order { get; set; }
		public int? PreviousId { get; set; }
		public int? NextId { get; set; }
		public int VideosCount { get; set; }
		public int VideosCompleted { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		
		public string Duration { get; set; }
	}
}