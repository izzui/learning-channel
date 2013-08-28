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
						Title = "Silver Jewerly",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Pearl Jewerly",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 3,
						Title = "Statement Jewerly",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 3). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 3
					},
					new Lesson
					{
						Id = 4,
						Title = "Solitaire Jewerly",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 4). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 4
					},//,
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
					new Lesson
					{
						Id = 41,
						Title = "Men's Watches",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 41). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 1
					},
					new Lesson
					{
						Id = 42,
						Title = "Women's Watches",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 42). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 2
					},
					new Lesson
					{
						Id = 43,
						Title = "Cocktails Watches",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 43). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 3
					}
				};
			}
		}
	}
}