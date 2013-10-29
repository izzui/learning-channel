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
					new Topic{Id = 1, Name = "Look Dia"},
					new Topic{Id = 2, Name = "Look Noite"},
					new Topic{Id = 3, Name = "Olhos"},
					new Topic{Id = 4, Name = "Boca"},
					new Topic{Id = 5, Name = "Rosto"},
					new Topic{Id = 6, Name = "Unhas"},
				};
			}
		}
	}
}