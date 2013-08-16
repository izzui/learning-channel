using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public IEnumerable<Author> Authors { get; set; }
		public string Thumb { get; set; }
		public double Price { get; set; }
		public double Rating { get; set; }
		public long Views { get; set; }
		public long Subscriptions { get; set; }
		public Lesson[] Lessons { get; set; }
		public DateTime PublishDate { get; set; }
		public string Language { get; set; }
		public Group[] Groups { get; set; }
	}
}