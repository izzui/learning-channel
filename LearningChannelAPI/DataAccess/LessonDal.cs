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
						Title = "Develop and Implement a Budget",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 41). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 1
					},
					new Lesson
					{
						Id = 42,
						Title = "Calculate Your Net Worth Using a Personal Balance Sheet",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 42). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 2
					},
					new Lesson
					{
						Id = 43,
						Title = "Develop a Personal Income Statement and Use It to Analyze Your Spending",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 43). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 3
					}
				};
			}
		}
	}
}