using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class CourseDAL
	{
		public Course Get(int id)
		{
			return List().SingleOrDefault(x => x.Id == id);
		}

		public Course[] List()
		{
			var courses = new Course[]
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
					Subscriptions = 1356,
					Thumb = "/thumbCourses/1.png",
					Title = "Curso de Tesde 1",
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
				},
				new Course
				{
					Id = 2,
					Authors = new Author[]
					{
						new Author {Id = 1, Name = "Andrey Britto"}
					},
					Price = 0,
					Rating = 4.5,
					Subscriptions = 1356,
					Thumb = "/thumbCourses/1.png",
					Title = "Curso de Teste 2",
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
				},
				new Course
				{
					Id = 3,
					Authors = new Author[]
					{
						new Author {Id = 1, Name = "Andrey Britto"}
					},
					Price = 0,
					Rating = 4.5,
					Subscriptions = 1356,
					Thumb = "/thumbCourses/1.png",
					Title = "Curso de Teste 3",
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
				}
			};
			return courses;
		}
	}
}