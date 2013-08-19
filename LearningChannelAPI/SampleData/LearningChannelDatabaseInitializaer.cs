using LearningChannelAPI.Data;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public class LearningChannelDatabaseInitializer : 
		//CreateDatabaseIfNotExists<LearningChannelContext>
		DropCreateDatabaseIfModelChanges<LearningChannelContext>
	{

		protected override void Seed(LearningChannelContext context)
		{
			var topics = AddTopics(context);
			var courses = AddCourses(context);
		}

		public List<Course> AddCourses(LearningChannelContext context)
		{
			var _courses = new Course[]
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
			
			var courses = new List<Course>();

			Array.ForEach(_courses, _course =>
			{
				var course = new Course
				{
					Language = _course.Language,
					Price = _course.Price,
					PublishDate = _course.PublishDate,
					Rating = _course.Rating,
					Subscriptions = _course.Subscriptions,
					Thumb = _course.Thumb,
					Title = _course.Title,
					Views = _course.Views,
				};
				courses.Add(course);
				context.Courses.Add(course);
			});
			context.SaveChanges();
			return courses;			
		}

		private void AddAuthors(LearningChannelContext context, IList<Course> courses)
		{

		}

		private List<Topic> AddTopics(LearningChannelContext context)
		{
			// Total number of rooms = (number of tracks) + (number of TheChosen people); see note in TheChosen.
			var names = new[] { 
                // 'Track' rooms (10 in use)
                "Artes e Ofícios", "Dicas do dia a dia", "Educação", "Esportes", "Estilo de vida", 
                "Gastronomia", "Gestão e negócios", "Jogos", "Línguas", "Moda",
                "Música", "Saúde", "Tecnologia"
            };
			var topics = new List<Topic>();
			Array.ForEach(names, name =>
			{
				var item = new Topic { Name = name };
				topics.Add(item);
				context.Topics.Add(item);
			});
			context.SaveChanges();
			return topics;
		}

	}

	
}