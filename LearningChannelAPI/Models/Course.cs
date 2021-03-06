﻿using System;
using System.Collections.Generic;
namespace LearningChannelAPI.Models
{
	public class Course
	{

		public Course()
		{
			this.Authors = new HashSet<Author>();
		}

		public int Id { get; set; }
		public string Title { get; set; }
		public string Lead { get; set; }
		public virtual ICollection<Author> Authors { get; private set; }
		public string Thumb { get; set; }
		public double Price { get; set; }
		public double Rating { get; set; }
		public long Views { get; set; }
		public long Subscriptions { get; set; }
		public ICollection<Lesson> Lessons { get; set; }
		public DateTime PublishDate { get; set; }
		public string Language { get; set; }
		public ICollection<Group> Groups { get; set; }
		public string Progress { get; set; }
		public string Description { get; set; }
		public string Target { get; set; }
		public string Objective { get; set; }
	}
}