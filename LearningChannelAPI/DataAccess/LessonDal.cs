﻿using System;
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
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 3,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 3).ToList(),
						CourseId = 1,
						Order = 3
					},
					new Lesson
					{
						Id = 4,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 4).ToList(),
						CourseId = 2,
						Order = 1
					},
					new Lesson
					{
						Id = 5,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 5).ToList(),
						CourseId = 2,
						Order = 2
					},
					new Lesson
					{
						Id = 6,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 6).ToList(),
						CourseId = 2,
						Order = 3
					},
					new Lesson
					{
						Id = 7,
						Title = "Introduction",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 7).ToList(),
						CourseId = 3,
						Order = 1
					},
					new Lesson
					{
						Id = 8,
						Title = "Unit 1",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 8).ToList(),
						CourseId = 3,
						Order = 2
					},
					new Lesson
					{
						Id = 9,
						Title = "Conclusion",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 9).ToList(),
						CourseId = 3,
						Order = 3
					}
				};
			}
		}
	}
}