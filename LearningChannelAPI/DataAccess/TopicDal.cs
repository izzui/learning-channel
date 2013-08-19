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
					new Topic{Id = 1, Name = "Artes e ofícios"},
					new Topic{Id = 2, Name = "Dicas do dia a dia"},
					new Topic{Id = 3, Name = "Educação"},
					new Topic{Id = 4, Name = "Esportes"},
					new Topic{Id = 5, Name = "Estilo de vida"},
					new Topic{Id = 6, Name = "Gastronomia"},
					new Topic{Id = 7, Name = "Gestão e negócios"},
					new Topic{Id = 8, Name = "Jogos"},
					new Topic{Id = 9, Name = "Línguas"},
					new Topic{Id = 10, Name = "Moda"},
					new Topic{Id = 11, Name = "Música"},
					new Topic{Id = 12, Name = "Saúde"},
					new Topic{Id = 13, Name = "Tecnologia"}
				};
			}
		}
	}
}