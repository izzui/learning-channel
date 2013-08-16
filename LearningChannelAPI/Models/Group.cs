using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Group
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string FacebookId { get; set; }
		[JsonIgnore]
		public int CourseId { get; set; }
	}
}