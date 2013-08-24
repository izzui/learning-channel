using Newtonsoft.Json;
namespace LearningChannelAPI.Models
{
	public class Rate
	{
		public int Id { get; set; }
		public double Score { get; set; }
		public string UserId { get; set; }
		[JsonIgnore]
		public int CourseId { get; set; }
	}
}