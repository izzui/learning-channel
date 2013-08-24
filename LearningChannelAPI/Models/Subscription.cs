namespace LearningChannelAPI.Models
{
	public class Subscription
	{
		public int Id { get; set; }
		public string UserId { get; set; }
		public int CourseId { get; set; }
		public double Rate { get; set; }
	}
}