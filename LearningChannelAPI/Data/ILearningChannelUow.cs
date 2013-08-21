using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using LearningChannelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningChannelAPI.Data
{
	public interface ILearningChannelUow : IDisposable
	{
		// Save pending changes to the data store.
		void Commit();

		// Repositories
		IRepository<Author> Authors { get; }
		IRepository<Board> Boards { get; }
		IRepository<Course> Courses { get; }
		IRepository<Group> Groups { get; }
		IRepository<Lesson> Lessons { get; }
		IRepository<Rate> Rates { get; }
		IRepository<Subscription> Subscriptions { get; }
		IRepository<Topic> Topics { get; }
		IRepository<User> Users { get; }
		IRepository<Video> Videos { get; }

	}
}
