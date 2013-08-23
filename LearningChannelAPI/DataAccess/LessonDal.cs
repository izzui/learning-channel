using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class LessonDal
	{
		public static IEnumerable<Lesson> Lessons
		{
			get
			{
				return new Lesson[]
				{
					new Lesson
					{
						Id = 1,
						Title = "1º Dia: Espírito Vencedor",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Guerreiro Oriental",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 3,
						Title = "Atitudes de um vendedor para vencer a batalha",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 3). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 3
					},
					new Lesson
					{
						Id = 4,
						Title = "Produtos Top",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 4). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 4
					}//,
					//new Lesson
					//{
					//	Id = 5,
					//	Title = "Unit 1",
					//	Videos = VideoDal.Videos.Where(v => v.LessonId == 5). OrderBy(v => v.Order).ToList(),
					//	CourseId = 2,
					//	Order = 2
					//},
					//new Lesson
					//{
					//	Id = 6,
					//	Title = "Conclusion",
					//	Videos = VideoDal.Videos.Where(v => v.LessonId == 6). OrderBy(v => v.Order).ToList(),
					//	CourseId = 2,
					//	Order = 3
					//},
					//new Lesson
					//{
					//	Id = 7,
					//	Title = "Introduction",
					//	Videos = VideoDal.Videos.Where(v => v.LessonId == 7). OrderBy(v => v.Order).ToList(),
					//	CourseId = 3,
					//	Order = 1
					//},
					//new Lesson
					//{
					//	Id = 8,
					//	Title = "Unit 1",
					//	Videos = VideoDal.Videos.Where(v => v.LessonId == 8). OrderBy(v => v.Order).ToList(),
					//	CourseId = 3,
					//	Order = 2
					//},
					//new Lesson
					//{
					//	Id = 9,
					//	Title = "Conclusion",
					//	Videos = VideoDal.Videos.Where(v => v.LessonId == 9). OrderBy(v => v.Order).ToList(),
					//	CourseId = 3,
					//	Order = 3
					//}
				};
			}
		}
	}
}