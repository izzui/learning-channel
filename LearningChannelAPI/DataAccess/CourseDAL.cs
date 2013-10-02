
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
						Price = 5,
						Rating = 4.5,
						Subscriptions = 549,
						Thumb = "thumb-ID00001.jpg",
						Title = "Indispensable Assistant",
						Lead = "Employees will learn proven techniques to be more productive, valueable and effective for your organization!",
						Views = 2478,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2011, 09, 30),
						Language = Languages.English,
						Progress = "90",
						Description = "In this powerful training course, SkillPath Corporate Strategies’ expert trainers offer your support staff proven techniques for becoming more productive, more valuable and more effective for your organization. We’ll gear the program to offer specific solutions for coordinating your organization’s unique projects and priorities, getting and staying organized and handling the pressure of multiple deadlines and bosses. What’s more, these new skills will inspire your assistants to greater self-confidence so they can work more independently and solve problems more confidently.",
						Objective = "Schedule this training course and create a win-win situation for everyone—your employees will learn the skills that make the difference between a job and a career, and your organization will reap the dividends of increased effectiveness and productivity.",
						Target = "Administrative assistants, secretaries, support staff and anyone who is responsible for coordinating, managing or being an effective member of an office team."
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
						Title = "Management Skills for Executive-level",
						Lead = "Prepare your employes for managerial responsibilities that will helpe expand their role.",
						Views = 1500,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "80",
						Description = "Give them that essential training on-site. This unique training course delivers the advanced training secretaries and assistants need to make decisions and solve problems on their own … to stay poised, confident and professional in any situation … to handle conflict … to persuade others to act … and to build harmonious working relationships with even the toughest personalities.",
						Objective = "They’ll walk away with a manager’s perspective for problem-solving, planning and coordinating. They’ll know how to create rapport and gain influence. And they’ll be able to juggle multiple projects, increase their productivity and contribute more to the organization.",
						Target = "Administrative assistants, secretaries, support staff and anyone who is responsible for coordinating, managing or being an effective member of an office team."
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
						Title = "Budgeting Skills for Professionals",
						Lead = "Turn budgeting into a dynamic goal-setting process rather than a dreaded chore.",
						Views = 4000,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "Our training course Budgeting Skills for Professionals was designed to do just that: Cut through layers of complex theory and confusing financial jargon and provide the nuts-and-bolts skills and techniques necessary to really understand the budgeting process.",
						Objective = "We’ll turn budgeting into a dynamic goal-setting process rather than a dreaded chore!",
						Target = "New or non-financial managers who are overwhelmed with cumbersome terms and confusing theories Experienced leaders ready to advance to a new budgeting level and discover the concepts and skills needed to get the most useful information."
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
						Title = "Administrative Professional Training",
						Lead = "Employees will boost communication skills, productivity and professional development!",
						Views = 4321,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 4).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 4).ToArray(),
						PublishDate = new DateTime(2013, 08, 21),
						Language = Languages.English,
						Progress = "0",
						Description = "In this era of dramatic change in the business world, assistants have never been more challenged … more stretched … than they are today. They’re expected to do whatever it takes to keep the “train moving” amidst the confusion brought on by re-engineering, restructuring and new technology.",
						Objective = "After this training course, employees will boost their communication skills, productivity, professional development and job satisfaction! They’ll learn new, practical skills that will enable them to manage their job and career with new professionalism, new authority and new success.",
						Target = "Administrative assistants, executive assistants, office managers, secretaries, support staff and anyone who is responsible for coordinating, managing or being an effective member of an office team."
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
						Title = "Excelling as a Highly Effective Team Leader",
						Lead = "Lead your team to a winning performance!",
						Views = 7534,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 5).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 5).ToArray(),
						PublishDate = new DateTime(2013, 8, 17),
						Language = Languages.English,
						Progress = "0",
						Description = "The clock is ticking, and it’s time to get your team into the game and producing results. But teamwork doesn’t just happen—it takes effective leadership to mold an assortment of individuals into a cohesive group that works together toward a common goal. In this powerful training course, our expert trainers will give your team the time-tested techniques other successful managers, supervisors and team leaders across the country are using to transform individuals into creative, effective and peak-performing teams.",
						Objective = "This training course will teach both new and veteran leaders how to be more confident and effective at leading teams, how crystal-clear communication is critical to high-performance teams and how to solve the myriad of problems that are sure to arise. And it will instill a passion that will allow them to rally their team to high-quality, top-notch performances day after day.",
						Target = "Directors, managers, supervisors and team leaders."
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
						Title = "OSHA Compliance Update",
						Lead = "How to provide a safe workplace for employees and satisfy every OSHA requirement.",
						Views = 2645,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 6).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 6).ToArray(),
						PublishDate = new DateTime(2013, 6, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "OSHA Compliance Update is a hard-hitting day of training that will bring new clarity to the challenge of achieving OSHA compliance and ensuring employee safety. Employees will get a highly informative crash course in the legal basics of OSHA.",
						Objective = "what’s expected, what’s changed, where there are loopholes and where your company may be veering off course. Employees also get the inside track on how to find hidden hazards before the inspector does and apply simple, cost-effective and swift fixes to ensure an OSHA-compliant work environment. This training is simply the best and fastest way to immerse employees in OSHA’s requirements.",
						Target = "Anyone who needs a update."
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
						Title = "Active Listening",
						Lead = "Master effective listening skills and nonverbal communication cues.",
						Views = 18547,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 1).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 1).ToArray(),
						PublishDate = new DateTime(2012, 10, 4),
						Language = Languages.English,
						Progress = "0",
						Description = "There’s a world of difference between hearing and listening. Active listening doesn’t come naturally, which is why this training course is ideal for all employees within an organization. When employees actively listen, they pay full attention, listen between the lines, notice nonverbal communication and ask the right questions.",
						Objective = "What participants will learn during this training will transform their personal and professional interactions—whether one-on-one or in meetings—and lead to more rewarding and meaningful communication with everyone in their life.",
						Target = "All employees within an organization."
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
						Title = "Emotional Intelligence (EI)",
						Lead = "Beyond people skills, EI training will improve relationships among employees.",
						Views = 17289,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 3).ToArray(),
						PublishDate = new DateTime(2012, 1, 1),
						Language = Languages.English,
						Progress = "85",
						Description = "Working effectively with all the different and difficult types of people in the workplace—from co-workers to customers to suppliers to higher-ups—isn’t easy. Success hinges on the ability of your employees to manage their emotions and the emotions of others to avoid miscommunications, resolve conflicts, reach consensus, build a cohesive work environment and get things done. Our revolutionary communication training course, Building Emotional Intelligence, goes far beyond “people skills” to boil down the essentials of emotional intelligence into language anyone can understand.",
						Objective = "Employees will obtain practical skills and motivation to improve relationships among fellow employees, reduce stress and increase productivity.",
						Target = "Business professionals who want to improve performance and relationships through emotional intelligence training."
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
						Title = "Strategic Thinking",
						Lead = "The key to better decisions, more effective problem solving and improved results.",
						Views = 15453,
						Lessons = LessonDal.Lessons.Where(x=>x.CourseId == 2).OrderBy(l => l.Order).ToArray(),
						Groups = GroupsDal.Groups.Where(x=>x.CourseId == 2).ToArray(),
						PublishDate = new DateTime(2012, 7, 27),
						Language = Languages.English,
						Progress = "0",
						Description = "In a world that’s changing as fast as ours, the ability to think strategically has become the responsibility of every employee—from the boardroom to the front line. Our training course, Strategic Thinking, introduces an innovative, new way to think about and approach the troubling business problems and challenges so many leaders are up against today.",
						Objective = "This training unpacks the skills, attitudes, traits and behaviors employees need to think critically, find new answers, uncover new opportunities and make better decisions.",
						Target = "No matter the job title or function, your employees will learn practical skills they can use to lead your teams, departments and organization to greater success."
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