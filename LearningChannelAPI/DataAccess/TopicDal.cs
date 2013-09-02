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
					new Topic{Id = 1, Name = "Small Business & Careers"},
					new Topic{Id = 2, Name = "Computers & Software"},
					new Topic{Id = 3, Name = "Consumer Electronics"},
					new Topic{Id = 4, Name = "Crafts & Hobbies"},
					new Topic{Id = 5, Name = "Education & Languages"},
					new Topic{Id = 6, Name = "Food & Drink"},
					new Topic{Id = 7, Name = "Health & Wellness"},
					new Topic{Id = 8, Name = "Home & Garden"},
					new Topic{Id = 9, Name = "Internet & Social Media"},
					new Topic{Id = 10, Name = "Music & Creative Arts"},
					new Topic{Id = 11, Name = "Personal Finance"},
					new Topic{Id = 12, Name = "Pets"},
					new Topic{Id = 13, Name = "Photography & Video"},
					new Topic{Id = 14, Name = "Relationships & Family"},
					new Topic{Id = 15, Name = "Religion & Spirituality"},
					new Topic{Id = 16, Name = "Sports & Outdoors"},
					new Topic{Id = 17, Name = "Games"}
				};
			}
		}
	}
}