using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class RateDal
	{
		public static IEnumerable<Rate> Rates
		{
			get
			{
				return new Rate[]
				{
					new Rate {Id = 1, UserId = "1", Score = 5, CourseId = 2},
					new Rate {Id = 2, UserId = "2", Score = 4.5, CourseId = 3},
					new Rate {Id = 3, UserId = "3", Score = 3.5, CourseId = 2}
				};
			}
		}
	}
}