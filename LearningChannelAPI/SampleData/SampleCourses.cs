using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleCourses
	{
		public static List<Course> sampleCourses;
		private static Course enrolled1, enrolled2, enrolled3,
			recent1, recent2, recent3,
			popular1, popular2, popular3,
			related1, related2, related3;

		public static void AddCourses(List<Course> courses)
		{
			sampleCourses = new List<Course>();
			sampleCourses.Add(enrolled1 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2012, 10, 4),
				Rating = 4.5,
				Subscriptions = 210,
				Thumb = "thumbCourses/inscrito1.png",
				Title = "Curso Inscrito 1",
				Views = 2435
			});
			sampleCourses.Add(enrolled2 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2013, 07, 27),
				Rating = 5,
				Subscriptions = 598,
				Thumb = "thumbCourses/inscrito2.png",
				Title = "Curso Inscrito 2",
				Views = 1367
			});
			sampleCourses.Add(enrolled3 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2012, 11, 26),
				Rating = 4,
				Subscriptions = 130,
				Thumb = "thumbCourses/inscrito3.png",
				Title = "Curso Inscrito 3",
				Views = 1435
			});
			sampleCourses.Add(recent1 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2013, 8, 1),
				Rating = 4.7,
				Subscriptions = 10,
				Thumb = "thumbCourses/recente1.png",
				Title = "Curso Recente 1",
				Views = 130
			});
			sampleCourses.Add(recent2 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2013, 8, 3),
				Rating = 4.7,
				Subscriptions = 15,
				Thumb = "thumbCourses/recente2.png",
				Title = "Curso Recente 2",
				Views = 216
			});
			sampleCourses.Add(recent3 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2013, 8, 7),
				Rating = 3.5,
				Subscriptions = 5,
				Thumb = "thumbCourses/recente3.png",
				Title = "Curso Recente 3",
				Views = 34
			});
			sampleCourses.Add(popular1 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2012, 1, 1),
				Rating = 4.7,
				Subscriptions = 3245,
				Thumb = "thumbCourses/popular1.png",
				Title = "Curso Popular 1",
				Views = 15000
			});
			sampleCourses.Add(popular2 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2012, 5, 26),
				Rating = 4.3,
				Subscriptions = 4873,
				Thumb = "thumbCourses/popular2.png",
				Title = "Curso Popular 2",
				Views = 83078
			});
			sampleCourses.Add(popular3 = new Course
			{
				Language = Languages.Portuese,
				Price = 0,
				PublishDate = new DateTime(2011, 12, 8),
				Rating = 4.0,
				Subscriptions = 11054,
				Thumb = "thumbCourses/popular3.png",
				Title = "Curso Popular 3",
				Views = 134345
			});
			courses.AddRange(sampleCourses);
		}
	}
}