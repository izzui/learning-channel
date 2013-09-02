
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
						Price = 0.99,
						Rating = 4.5,
						Subscriptions = 549,
						Thumb = "thumb-ID00001.jpg",
						Title = "CSS Web Design",
						Views = 2478,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
						Progress = "60",
						Description = "Cascading Style Sheets (CSS) is a Web markup standard that allows Web designers to define the appearance and position of a Web page using special dynamic effects. This course is the perfect beginner reference, showing those new to CSS how to design Web pages and implement numerous useful CSS effects available. Seasoned For Dummies author Richard Mansfield explains how CSS can streamline and speed up Web development. Explains how to take control of the many elements in a Web page, integrate CSS into new or existing sites, choose the best coding techniques, and execute advanced visual effects such as transitions. U Features a special discussion on browser incompatibility issues involving CSS and how to solve potential pro.",
						Objective = "You will learn to write all of your own CSS and HTML, even if you use visual web authoring software.",
						Target = "Begginers in web design."
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
						Title = "Building Facebook Applications",
						Views = 1500,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.Portuguese,
						Progress = "70",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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
						Title = "Building Websites",
						Views = 4000,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.Spanish,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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
						Rating = 2.5,
						Subscriptions = 1335,
						Thumb = "thumb-ID00004.jpg",
						Title = "Energy Efficient Homes For Dummies",
						Views = 4321,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 4).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 4).ToArray(),
						PublishDate = new DateTime(2013, 08, 21),
						Language = Languages.Spanish,
						Progress = "85",
						Description = "Hands-on, practical solutions to save money by making smart energy changes. One of the best and most affordable strategies people can employ to combat global warming is to improve the energy and water efficiency of their homes. Energy Efficient Homes For Dummies provides homeowners with advice, tips, and projects to reduce costs, increase energy efficiency, and cut down on waste and pollution. After performing a do-it-yourself home energy audit, readers create an action plan based on their personal goals. Readers are presented with a wide range of potential solutions, from making better use of blinds and awnings to exploring geothermal options in order to reduce household costs and their impact on the planet.",
						Objective = "Let the student be able to became efficient when dealing with energy at home.",
						Target = "This course was specially developed for... you."
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
						Title = "Energy-Saving Tips For Dummies",
						Views = 7534,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 5).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 5).ToArray(),
						PublishDate = new DateTime(2013, 6, 17),
						Language = Languages.Spanish,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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
						Title = "Composting For Dummies",
						Views = 2645,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 6).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 6).ToArray(),
						PublishDate = new DateTime(2013, 8, 1),
						Language = Languages.Spanish,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
					},
					new Course
					{
						Id = 7,
						//Authors = new Author[]
						//{
						//	new Author {Id = 1, Name = "Andrey Britto"}
						//},
						Price = 0.99,
						Rating = 1.5,
						Subscriptions = 3102,
						Thumb = "thumb-ID00007.jpg",
						Title = "Green Building & Remodeling For Dummies",
						Views = 18547,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
						Progress = "60",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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
						Title = "Green Careers For Dummies",
						Views = 17289,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.Spanish,
						Progress = "85",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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
						Title = "Green Cleaning For Dummies",
						Views = 15453,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.Portuguese,
						Progress = "70",
						Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
						Objective = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation.",
						Target = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
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