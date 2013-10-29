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
						Title = "Another Perspective on Wealth",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Setting Personal Goals",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 3,
						Title = "Understanding and Managing Credit",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 3). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 3
					},
					new Lesson
					{
						Id = 41,
						Title = " Apresentação Hypnose Palette",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 41). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 1
					},
					new Lesson
					{
						Id = 42,
						Title = "Hypnose Palette",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 42). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 2
					},
					new Lesson
					{
						Id = 43,
						Title = "Tutorial",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 43). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 3
					},
					new Lesson
					{
						Id = 44,
						Title = "Outros produtos Hypnose",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 44). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 4
					}
				};
			}
		}
	}
}