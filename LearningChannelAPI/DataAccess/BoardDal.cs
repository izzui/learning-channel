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
					new Board{Username = "Roberto Campos", Score = 19093202, Date = System.DateTime.Now, Thumb = "pic-ID00001.jpg"},
					new Board{Username = "Bernardo Castanheira", Score = 19093205, Date = System.DateTime.Now, Thumb = "pic-ID00002.jpg"},
					new Board{Username = "Henrique Rabelo", Score = 19093207, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00003.jpg"},
					new Board{Username = "Demetrius Nunes", Score = 19093254, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00004.jpg"},
					new Board{Username = "Vicente Sarmento", Score = 1909456, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00005.jpg"},
					new Board{Username = "Andrey Britto", Score = 19093452, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00006.jpg"},
					new Board{Username = "Fabio Figueiredo", Score = 19045602, Date = System.DateTime.Now, Thumb = "pic-ID00007.jpg"},
					new Board{Username = "Antonio Affonseca", Score = 19096752, Date = System.DateTime.Now, Thumb = "pic-ID00008.jpg"},
					new Board{Username = "Beto Lucena", Score = 190956502, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00009.jpg"},
					new Board{Username = "Renata Inireu", Score = 1905502, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00010.jpg"},
					new Board{Username = "Vladimir Cunha", Score = 196565202, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00010.jpg"},
					new Board{Username = "Felipe Menezes", Score = 190556202, Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00010.jpg"}
				};
			}
		}
	}
}