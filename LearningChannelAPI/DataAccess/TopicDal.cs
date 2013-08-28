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
					new Topic{Id = 1, Name = "Bracelets"},
					new Topic{Id = 2, Name = "Broochs"},
					new Topic{Id = 3, Name = "Charms"},
					new Topic{Id = 4, Name = "Earrings"},
					new Topic{Id = 5, Name = "Necklaces & Pendants"},
					new Topic{Id = 6, Name = "Rings"},
					new Topic{Id = 7, Name = "Silver Jewelry"},
					new Topic{Id = 8, Name = "Pearl Jewelry"},
					new Topic{Id = 9, Name = "Watches"},
					new Topic{Id = 10, Name = "Designers & Collections"},
					new Topic{Id = 11, Name = "Accessories"},
					new Topic{Id = 12, Name = "Pink Diamonds"},
					new Topic{Id = 13, Name = "Yellow Diamonds"}
				};
			}
		}
	}
}