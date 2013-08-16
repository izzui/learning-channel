using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Rate
	{
		public int Id { get; set; }
		public double Score { get; set; }
		public string FacebookId { get; set; }
		[JsonIgnore]
		public int CourseId { get; set; }
	}
}