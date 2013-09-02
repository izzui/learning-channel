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
						Title = "Part I: The ABCs of CSS",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Part II: Looking Good with CSS",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 3,
						Title = "Part III: Adding Artistry: Design and Composition with CSS",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 3). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 3
					},
					new Lesson
					{
						Id = 4,
						Title = "Part IV: Advanced CSS Techniques",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 4). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 4
					},
					new Lesson
					{
						Id = 5,
						Title = "Part V: The Part of Tens",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 5). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 5
					},
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
						Title = "Part I: Solving the World’s Problems from Your Front Porch",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 41). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 1
					},
					new Lesson
					{
						Id = 42,
						Title = "Part II: Reducing Inefficiencies throughout Your Home",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 42). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 2
					},
					new Lesson
					{
						Id = 43,
						Title = "Part III: Putting Alternative Energy Sources to Work for You",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 43). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 3
					},
					new Lesson
					{
						Id = 44,
						Title = "Part IV: Considering Efficiency When You Buy, Build, or Sell a Home",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 44). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 4
					},
					new Lesson
					{
						Id = 45,
						Title = "Part V: The Part of Tens",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 43). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 5
					}
				};
			}
		}
	}
}