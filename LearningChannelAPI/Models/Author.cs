using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Author
	{

		public Author()
		{
			this.Courses = new HashSet<Course>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string FacebookId { get; set; }
		public string Twitter { get; set; }
		public string GooglePlus { get; set; }
		public string LinkedIn { get; set; }
		public virtual ICollection<Course> Courses { get; private set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }
	}
}