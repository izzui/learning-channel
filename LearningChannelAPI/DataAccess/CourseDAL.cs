
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
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Andrey Britto"}
						//},
						Price = 0,
						Rating = 4.5,
						Subscriptions = 549,
						Thumb = "thumb-ID00001.jpg",
						Title = "Técnicas de Corte Master Results",
						Lead = "Seja um Master Cabeleireiro em Corte",
						Views = 2478,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2011, 09, 30),
						Language = Languages.English,
						Progress = "90",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 2,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Roberto Campos"}
						//},
						Price = 5,
						Rating = 3,
						Subscriptions = 230,
						Thumb = "thumb-ID00002.jpg",
						Title = "Descoloração",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 1500,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "80",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 3,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Bernardo Castanheira"},
						//	new Author {Id = 1, Name = "Henrique Rabello"}
						//},
						Price = 10,
						Rating = 5,
						Subscriptions = 1465,
						Thumb = "thumb-ID00003.jpg",
						Title = "Aplicação de Gel Fixador",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 4000,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 4,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Bernardo Castanheira"},
						//	new Author {Id = 1, Name = "Henrique Rabello"}
						//},
						Price = 10,
						Rating = 5,
						Subscriptions = 1335,
						Thumb = "thumb-ID00004.jpg",
						Title = "Técnicas de Tratamento Master Results",
						Lead = "Seja um Master Cabeleireiro em Tratamento",
						Views = 4321,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 4).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 4).ToArray(),
						PublishDate = new DateTime(2013, 08, 21),
						Language = Languages.Portuguese,
						Progress = "0",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 5,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Bernardo Castanheira"},
						//	new Author {Id = 1, Name = "Henrique Rabello"}
						//},
						Price = 10,
						Rating = 1,
						Subscriptions = 872,
						Thumb = "thumb-ID00005.jpg",
						Title = "Corte Básico: Cabelos Lisos",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 7534,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 5).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 5).ToArray(),
						PublishDate = new DateTime(2013, 8, 17),
						Language = Languages.English,
						Progress = "0",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 6,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Bernardo Castanheira"},
						//	new Author {Id = 1, Name = "Henrique Rabello"}
						//},
						Price = 10,
						Rating = 3.5,
						Subscriptions = 345,
						Thumb = "thumb-ID00006.jpg",
						Title = "Técnicas de Coloroação Master Results",
						Lead = "Saiba qual base combina melhor com sua pele",
						Views = 2645,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 6).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 6).ToArray(),
						PublishDate = new DateTime(2013, 6, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 7,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Andrey Britto"}
						//},
						Price = 0,
						Rating = 1.5,
						Subscriptions = 3102,
						Thumb = "thumb-ID00007.jpg",
						Title = "Corte Básico: Cabelos Crespos",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 18547,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
						Progress = "0",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 8,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Bernardo Castanheira"},
						//	new Author {Id = 1, Name = "Henrique Rabello"}
						//},
						Price = 10,
						Rating = 2,
						Subscriptions = 2987,
						Thumb = "thumb-ID00008.jpg",
						Title = "Corte Básico: Cabelos Cacheados",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 17289,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					},
					new Course
					{
						Id = 9,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Roberto Campos"}
						//},
						Price = 4,
						Rating = 4.5,
						Subscriptions = 2230,
						Thumb = "thumb-ID00009.jpg",
						Title = "Técnicas de Escova",
						Lead = "Donec nec massa egestas, feugiat nulla vel, sollicitudin odit.",
						Views = 15453,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "0",
						Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris. Vivamus in augue mattis, ornare turpis quis, vehicula erat. Suspendisse laoreet a augue ut faucibus. Phasellus egestas mi orci, vitae rhoncus libero accumsan eget.",
						Objective = "Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.",
						Target = "Todas as pessoas que quiserem arrasar no visual."
					}

				};
			}
		}

		public Course[] List(string language, int pageNumber, int pageSize, string sort)
		{
			var courses = Courses.Where(x => x.Language.Contains(language) || Languages.AllLanguages.Equals(language)).AsEnumerable<Course>();
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