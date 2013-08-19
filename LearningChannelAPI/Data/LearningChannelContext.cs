using LearningChannelAPI.Models;
using LearningChannelAPI.SampleData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Data
{
	public class LearningChannelContext : DbContext
	{
		public LearningChannelContext() : base("LearningChannel")
		{
			
		}

		public DbSet<Topic> Topics { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<Author> Authors  { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Lesson> Lessons { get; set; }
		public DbSet<Video> Videos { get; set; }

		static LearningChannelContext()
		{
			Database.SetInitializer(new LearningChannelDatabaseInitializer());
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

	}
}