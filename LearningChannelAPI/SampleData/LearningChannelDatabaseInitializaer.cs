using System.Linq;
using LearningChannelAPI.Data;
using LearningChannelAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace LearningChannelAPI.SampleData
{
	public class LearningChannelDatabaseInitializer : 
		DropCreateDatabaseAlways<LearningChannelContext>
		//CreateDatabaseIfNotExists<LearningChannelContext>
		//DropCreateDatabaseIfModelChanges<LearningChannelContext>
	{

		protected override void Seed(LearningChannelContext context)
		{
			AddTopics(context);
			var courses = AddCourses(context);
			var lessons = AddLessons(context, courses);
			AddVideos(context, lessons);
			AddGroups(context, courses);
			var authors =	AddAuthors(context);
			AddCourseAuthor(context, courses, authors);
			var users  = AddUsers(context);
		}

		private object AddUsers(LearningChannelContext context)
		{
			var users = new List<User>();
			SampleUsers.AddUsers(users);
			return null;
		}

		private List<Course> AddCourses(LearningChannelContext context)
		{
			var courses = new List<Course>();
			SampleCourses.AddCourses(courses);
			courses.ForEach(course =>
			{
				context.Courses.Add(course);
			});
		
			context.SaveChanges();
			return courses;			
		}

		private void AddGroups(LearningChannelContext context, List<Course> courses)
		{
			var groups = new List<Group>();
			courses.ForEach(course =>
			{
				SampleGroups.AddGroups(groups, course);
				groups.ForEach(group =>
				{
					context.Groups.Add(group);
				});
			});
			context.SaveChanges();
		}


		private List<Lesson> AddLessons(LearningChannelContext context, List<Course> courses)
		{
			var sampleLessons = new List<Lesson>();
			var lessons = new List<Lesson>();
			courses.ForEach(course =>
			{
				SampleLessons.AddLessons(lessons, course);
				lessons.ForEach(lesson =>
				{
					sampleLessons.Add(lesson);
					context.Lessons.Add(lesson);
				});
			});
			context.SaveChanges();
			return sampleLessons;
		}

		private void AddVideos(LearningChannelContext context, List<Lesson> lessons)
		{
			var videos = new List<Video>();
			lessons.ForEach(lesson =>
			{
				SampleVideos.AddVideos(videos, lesson);
				videos.ForEach(video =>
				{
					context.Videos.Add(video);
				});
			});
			context.SaveChanges();
		}

		private List<Author> AddAuthors(LearningChannelContext context)
		{
			var authors = new List<Author>();
			var sampleAuthors = new List<Author>();
			SampleAuthors.AddAuthors(authors);
			authors.ForEach(author =>
			{
				sampleAuthors.Add(author);
				context.Authors.Add(author);
			});
			context.SaveChanges();
			return sampleAuthors;
		}

		private void AddCourseAuthor(LearningChannelContext context, List<Course> courses, List<Author> authors)
		{
			var list = new Dictionary<int, int[]>();
			list.Add(1, new[] { 0, 1 });
			list.Add(2, new[] { 2 });
			list.Add(3, new[] { 3 });
			list.Add(4, new[] { 4, 5 });
			list.Add(5, new[] { 1 });
			list.Add(6, new[] { 3, 5 });
			list.Add(7, new[] { 0 });
			list.Add(8, new[] { 5 });
			list.Add(9, new[] { 4, 2 });

			courses.ForEach(course =>
			{
				foreach (int index in list[course.Id])
				{
					course.Authors.Add(authors[index]);
				}
			});
			context.SaveChanges();
		}

		private void AddTopics(LearningChannelContext context)
		{
			// Total number of rooms = (number of tracks) + (number of TheChosen people); see note in TheChosen.
			var names = new[] { 
                // 'Track' rooms (10 in use)
                "Artes e Ofícios", "Dicas do dia a dia", "Educação", "Esportes", "Estilo de vida", 
                "Gastronomia", "Gestão e negócios", "Jogos", "Línguas", "Moda",
                "Música", "Saúde", "Tecnologia"
            };
			Array.ForEach(names, name =>
			{
				var item = new Topic { Name = name };
				context.Topics.Add(item);
			});
			context.SaveChanges();
		}

	}

	
}