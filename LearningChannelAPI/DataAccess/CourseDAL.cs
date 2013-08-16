using System;
using System.Collections.Generic;
using System.Linq;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.DataAccess
{
	public class CourseDal
	{

		// Dados Fakes
		public static IEnumerable<Course> Courses
		{
			get
			{
				return new Course[]
				{
					new Course
					{
						Id = 1,
						Authors = new Author[]
						{
							new Author {Id = 1, Name = "Andrey Britto"}
						},
						Price = 0,
						Rating = 4.5,
						Subscriptions = 549,
						Thumb = "/thumbCourses/1.png",
						Title = "Test Course 1",
						Views = 2478,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
					},
					new Course
					{
						Id = 2,
						Authors = new Author[]
						{
							new Author {Id = 1, Name = "Roberto Campos"}
						},
						Price = 0,
						Rating = 4.5,
						Subscriptions = 230,
						Thumb = "/thumbCourses/1.png",
						Title = "Curso de Teste 2",
						Views = 1500,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2013, 7, 27),
						Language = Languages.Portuese
					},
					new Course
					{
						Id = 3,
						Authors = new Author[]
						{
							new Author {Id = 1, Name = "Bernardo Castanheira"},
							new Author {Id = 1, Name = "Henrique Rabello"}
						},
						Price = 0,
						Rating = 4.5,
						Subscriptions = 1465,
						Thumb = "/thumbCourses/1.png",
						Title = "Curso de prueba 3",
						Views = 4000,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 3).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2013, 1, 1),
						Language = Languages.Spanish
					}
				};
			}
		}

		public Course[] List(string language, int pageNumber, int courseRelated, int pageSize, string sort)
		{

			var courses = Courses.Where(x => x.Language.Contains(language) || Languages.AllLanguages.Equals(language));



			courses = Sort(sort, courses);
			courses = Paginate(pageNumber, pageSize, courses);
			return courses.ToArray();
		}

		private IEnumerable<Course> Paginate(int pageNumber, int pageSize, IEnumerable<Course> courses)
		{
			var first = (pageNumber - 1) * pageSize;
			var limit = pageSize;
			return courses.Skip(first).Take(limit).ToArray();
		}

		private IEnumerable<Course> Sort(string sort, IEnumerable<Course> courses)
		{
			switch (sort)
			{
				case CoursesSorter.Publishdate:
					return courses.OrderByDescending(x => x.PublishDate);
				case CoursesSorter.Subscriptions:
					return courses.OrderByDescending(x => x.Subscriptions);
				case CoursesSorter.Views:
					return courses.OrderByDescending(x => x.Views);
				case CoursesSorter.Title:
					return courses.OrderBy(x => x.Title);
			}
			return courses;
		}
	}
}