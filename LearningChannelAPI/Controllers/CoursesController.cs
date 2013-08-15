using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Controllers
{
	public class CoursesController : ApiController
	{
		// GET api/<controller>
		[HttpGet]
		public IEnumerable<Course> List()
		{
			var courses = new Course[]
			{
				new Course{ Id = 1, Authors = new Author[] {new Author{ Id = 1, Name = "Andrey Britto"}}, Price = 0, Rating = 4.5, Subscriptions = 1356, Thumb = "/thumbCourses/1.png", Title = "Curso de Testde 1", Views = 2478},
				new Course{ Id = 2, Authors = new Author[] {new Author{ Id = 2, Name = "Roberto Campos"}}, Price = 0, Rating = 3.5, Subscriptions = 567, Thumb = "/thumbCourses/2.png", Title = "Curso de Testde 2", Views = 1834},
				new Course{ Id = 3, Authors = new Author[] {new Author{ Id = 3, Name = "Bernardo Castanheira"}}, Price = 0, Rating = 2, Subscriptions = 10, Thumb = "/thumbCourses/3.png", Title = "Curso de Testde 3", Views = 100},
				//new Course(), 
			};

			return courses;
		}

		// GET api/<controller>/5
		public Course Get(int id)
		{
			var course = new Course
			{
				Id = 1,
				Authors = new Author[]
				{
					new Author {Id = 1, Name = "Andrey Britto"}
				},
				Price = 0,
				Rating = 4.5,
				Subscriptions = 1356,
				Thumb = "/thumbCourses/1.png",
				Title = "Curso de Testde 1",
				Views = 2478,
				Lessons = new Lesson[]
				{
					new Lesson{
						Id = 1, 
						Title = "Introduction", 
						Videos = new Video[]
						{
							new Video{Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1"},
							new Video{Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2"}
						}
					},
					new Lesson{
						Id = 2, 
						Title = "Unit 1", 
						Videos = new Video[]
						{
							new Video{Id = 3, Thumb = "/videos/3.png", Url = "http://youtube.com/video3"},
							new Video{Id = 4, Thumb = "/videos/4.png", Url = "http://youtube.com/video4"},
							new Video{Id = 5, Thumb = "/videos/5.png", Url = "http://youtube.com/video5"},
							new Video{Id = 6, Thumb = "/videos/6.png", Url = "http://youtube.com/video6"}
						}
					},
					new Lesson{
						Id = 3, 
						Title = "Conclusion", 
						Videos = new Video[]
						{
							new Video{Id = 7, Thumb = "/videos/7.png", Url = "http://youtube.com/video7"},
						}
					}
				}
			};
			return course;
		}

		// POST api/<controller>
		public void Post([FromBody]string value)
		{
			throw new InvalidOperationException();
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value)
		{
			throw new InvalidOperationException();
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
			throw new InvalidOperationException();
		}
	}
}