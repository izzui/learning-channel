using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class VideoSource
	{
		public int Id { get; set; }
		public int VideoId { get; set; }
		public string Url { get; set; }
		public string Type { get; set; }
	}
}