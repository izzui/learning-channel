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
						Title = "Introdução",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 1). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 1
					},
					new Lesson
					{
						Id = 2,
						Title = "Curto, Médio e Longo",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 2). OrderBy(v => v.Order).ToList(),
						CourseId = 1,
						Order = 2
					},
					new Lesson
					{
						Id = 41,
						Title = "Introdução",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 41). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 1
					},
					new Lesson
					{
						Id = 42,
						Title = "Escova de Controle & Nutrição de Choque",
						Videos = VideoDal.Videos.Where(v => v.LessonId == 42). OrderBy(v => v.Order).ToList(),
						CourseId = 4,
						Order = 2
					}
				};
			}
		}
	}
}