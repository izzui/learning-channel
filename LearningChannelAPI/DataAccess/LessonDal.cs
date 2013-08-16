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
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 1).ToArray(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 2).ToArray(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 3,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 3).ToArray(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 4,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 4).ToArray(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 5,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 5).ToArray(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 6,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 6).ToArray(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 7,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 7).ToArray(),
						CourseId = 3
					},
					new Lesson
					{
						Id = 8,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 8).ToArray(),
						CourseId = 3
					},
					new Lesson
					{
						Id = 9,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(x=>x.LessonId == 9).ToArray(),
						CourseId = 3
					}
				};
			}
		}
	}
}