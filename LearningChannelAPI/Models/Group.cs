using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace LearningChannelAPI.Models
{
	public class Group
	{
		public long Id { get; set; }
		[StringLength(256)]
		public string Name { get; set; }
		[StringLength(15)]
		public string FacebookId { get; set; }
		[JsonIgnore]
		public int CourseId { get; set; }
	}
}