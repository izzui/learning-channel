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
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 1 && lv.VideoId == l.Id)).ToList(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 2 && lv.VideoId == l.Id)).ToList(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 3,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 3 && lv.VideoId == l.Id)).ToList(),
						CourseId = 1
					},
					new Lesson
					{
						Id = 4,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 4 && lv.VideoId == l.Id)).ToList(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 5,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 5 && lv.VideoId == l.Id)).ToList(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 6,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 6 && lv.VideoId == l.Id)).ToList(),
						CourseId = 2
					},
					new Lesson
					{
						Id = 7,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 7 && lv.VideoId == l.Id)).ToList(),
						CourseId = 3
					},
					new Lesson
					{
						Id = 8,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 8 && lv.VideoId == l.Id)).ToList(),
						CourseId = 3
					},
					new Lesson
					{
						Id = 9,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(l => LessonVideoDal.LessonsVideos.Any(lv => lv.LessonsId == 9 && lv.VideoId == l.Id)).ToList(),
						CourseId = 3
					}
				};
			}
		}
	}
}