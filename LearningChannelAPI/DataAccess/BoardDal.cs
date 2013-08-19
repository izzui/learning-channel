using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class BoardDal
	{
		public static Board[] Scores
		{
			get
			{
				return new Board[]
				{
					new Board{UserName = "Roberto Campos", Score = 19093202, Date = System.DateTime.Now},
					new Board{UserName = "Bernardo Castanheira", Score = 19093202, Date = System.DateTime.Now},
					new Board{UserName = "Henrique Rabelo", Score = 19093202, Date = System.DateTime.Now.AddDays(-10)},
					new Board{UserName = "Demetrius Nunes", Score = 19093202, Date = System.DateTime.Now.AddDays(-10)},
					new Board{UserName = "Vicente Sarmento", Score = 19093202, Date = System.DateTime.Now.AddDays(-10)},
					new Board{UserName = "Andrey Britto", Score = 19093202, Date = System.DateTime.Now.AddDays(-10)},
				};
			}
		}
	}
}