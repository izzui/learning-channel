using LearningChannelAPI.Models;
using System;

namespace LearningChannelAPI.DataAccess
{
	public class BoardDal
	{
		public static Board[] Scores
		{
			get
			{
                var randow = new Random();
				return new Board[]
				{
					new Board{Username = "Roberto Campos", Score = randow.Next(1000), Date = System.DateTime.Now, Thumb = "pic-ID00001.jpg"},
					new Board{Username = "Bernardo Castanheira", Score = randow.Next(1000), Date = System.DateTime.Now, Thumb = "pic-ID00002.jpg"},
					new Board{Username = "Henrique Rabelo", Score = randow.Next(1000), Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00003.jpg"},
					new Board{Username = "Demetrius Nunes", Score = randow.Next(1000), Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00004.jpg"},
					new Board{Username = "Vicente Sarmento", Score = randow.Next(1000), Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00005.jpg"},
					new Board{Username = "Andrey Britto", Score = randow.Next(1000), Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00006.jpg"},
					new Board{Username = "Fabio Figueiredo", Score = randow.Next(1000), Date = System.DateTime.Now, Thumb = "pic-ID00007.jpg"},
					new Board{Username = "Antonio Affonseca", Score = randow.Next(1000), Date = System.DateTime.Now, Thumb = "pic-ID00008.jpg"},
					new Board{Username = "Beto Lucena", Score = randow.Next(1000), Date = System.DateTime.Now.AddDays(-10), Thumb = "pic-ID00009.jpg"},
				};
			}
		}
	}
}