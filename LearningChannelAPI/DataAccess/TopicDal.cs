using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class TopicDal
	{
		public static Topic[] Topics
		{
			get
			{
				return new Topic[]
				{
					new Topic{Id = 1, Name = "Administrative Support Training"},
					new Topic{Id = 2, Name = "Customer Service"},
					new Topic{Id = 3, Name = "Finance and Accounting"},
					new Topic{Id = 4, Name = "Human Resources"},
					new Topic{Id = 5, Name = "Interpersonal Skills Training"},
					new Topic{Id = 6, Name = "Leadership & Management"},
					new Topic{Id = 7, Name = "Professional Communication Skills"},
					new Topic{Id = 8, Name = "Safety Training"},
					new Topic{Id = 9, Name = "Sales Training"},
					new Topic{Id = 10, Name = "Social Media / Marketing"},
					new Topic{Id = 11, Name = "Teambuilding"},
					new Topic{Id = 12, Name = "Time and Project Management"}		
				};
			}
		}
	}
}