
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
						Title = "Arrase no Trabalho",
						Lead = "Bela maquiagem para marcar uma bela presença no trabalho",
						Views = 2478,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2011, 09, 30),
						Language = Languages.English,
						Progress = "90",
						Description = "This is a beginning course on the importance of perspective and wealth. Perspective is important in studying personal finance. Our view of the way we look at ourselves, at life, and at others will have an important impact on how we utilize the resources that we have. It is critical that we have a correct perspective.",
						Objective = " We will also discuss four important principles of personal finance that constitute another perspective on wealth.",
						Target = "This course is recommended for all individuals."
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
						Title = "Festa à Fantasia",
						Lead = "Turbine seu look com essa versátil maquiagem e arrase na festa!",
						Views = 1500,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "80",
						Description = "This is a beginning course on Setting Personal Goals and building your own Personal Financial Plan. Knowing what you want to accomplish in life is critical to any discussion on Financial Planning. Your goals are what you want to achieve in life. The purpose of Financial Planning is to help you to achieve your personal and family goals, and if you don't know what you want to accomplish, all financial planning can do is to help you to be more efficient in saving.",
						Objective = "With the successful conclusion of this assignments, you will have written down the things you want to accomplish in life, your short-, medium-, and long-term goals. You will have taken your top three goals, and written about them in detail. You will have written your epitaph, what you want to be remembered about in life.",
						Target = " This course is recommended for all individuals."
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
						Title = "Impressione em um Casamento",
						Lead = "Esteja à altura dessa grandiosa festa",
						Views = 4000,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "This is a beginning course on the importance of understanding open credit. It discusses credit reports, and credit cards, and addresses the benefits and challenges of credit cards and other similar instruments.",
						Objective = "As an assignment, I recommend that you get a free copy of your credit report, and also to pay for a copy of your credit score.  Instructions are given how to obtain both.",
						Target = "This course is recommended for all individuals."
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
						Title = "Impressione em um Encontro",
						Lead = "Fácil e rápido de aplicar, com resultado espetacular",
						Views = 4321,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 4).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 4).ToArray(),
						PublishDate = new DateTime(2013, 08, 21),
						Language = Languages.English,
						Progress = "0",
						Description = " This is a course on the importance of budgeting and measuring your financial health. This course gives a 'better way' for budgeting, which is to pay yourself first.",
						Objective = "there is a budgeting spreadsheet (Teaching Tool 4: Budget Spreadsheet) that can be used to help you as you prepare your budget.",
						Target = "This course is recommended for all individuals."
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
						Title = "Impressione em uma Festa",
						Lead = "Maquiagem para pessoas que possuem ainda pouca prática",
						Views = 7534,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 5).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 5).ToArray(),
						PublishDate = new DateTime(2013, 8, 17),
						Language = Languages.English,
						Progress = "0",
						Description = "This is a intermediate course on the importance of understanding and managing your cash and short-term investments wisely.  It considers both traditional and non-traditional cash management alternatives, and gives a history of interest rates for most alternatives.",
						Objective = "There is provided a spreadsheet to help you calculate the taxable yield and equivalent taxable yields for various cash management alternatives.",
						Target = "This course is recommended for most individuals."
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
						Title = "Escolha base perfeita",
						Lead = "Saiba qual base combina melhor com sua pele",
						Views = 2645,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 6).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 6).ToArray(),
						PublishDate = new DateTime(2013, 6, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "It discusses the different types of consumer loans, from the lowest cost, to the highest cost, and gives recommendations if you must finance consumer loans.  It also gives a description of the different types of mortgage loans, and aids in the choosing between the various options for home financing.",
						Objective = "As an assignment,  I recommend that you get either a financial calculator, or use the Excel based financial calculator from the Teaching Tools.  You will learn how to use your financial calculators in the process of learning about the time value of money.",
						Target = "This course is recommended for all individuals."
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
						Title = "Batons, cores e significados",
						Lead = "Aprenda sobre tipos de batons, cores e os significados por trás delas",
						Views = 18547,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
						Progress = "0",
						Description = "It discusses the underlying reasons we go into debt, and how to get yourself out of debt once you are in debt.",
						Objective = "May be useful in helping you get out of debt if you are currently in debt.",
						Target = "This course is recommended for all individuals."
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
						Title = "Amplie o seu olhar",
						Lead = "Amplie os olhos e fique com cara de mulherão",
						Views = 17289,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "It includes the major types of insurance most individuals and families should be concerned about, including life insurance, health insurance, and auto, homeowners and liability insurance. It gives the benefits and costs of the different types of insurance and then gives recommendations as to how to best meet your needs.",
						Objective = " None. The lesson on Another Perspective is recommended before you take this course.",
						Target = "This course is recommended for individuals with some college and some math."
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
						Title = "Mude a cor das sobrancelhas",
						Lead = "Todo cuidado é pouco: parece simples, mas há questões sobre usar a mesma tinta do cabelo na sobrancelha! Aprenda como fazer corretamente!",
						Views = 15453,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "0",
						Description = "It includes the benefits of life insurance, the five key questions of life insurance, the different types of life insurance, and the steps to buying life insurance.",
						Objective = "Understand the benefits of life insurance.",
						Target = "This course is recommended for individuals with some college and some math ability."
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