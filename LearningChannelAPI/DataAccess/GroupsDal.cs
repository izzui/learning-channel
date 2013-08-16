using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class GroupsDal
	{
		public static IEnumerable<Group> Groups
		{
			get
			{
				return new Group[]
				{
					new Group {Id = 1, UserId = 3, Name = "Group 2", CourseId = 2},
					new Group {Id = 2, UserId = 2, Name = "Group 3", CourseId = 3},
					new Group {Id = 3, UserId = 1, Name = "Group 3", CourseId = 2}
				};
			}
		}
	}
}