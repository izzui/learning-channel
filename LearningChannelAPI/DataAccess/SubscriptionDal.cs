using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class SubscriptionDal
	{

		public static Subscription[] Subscriptions
		{
			get
			{
				return new Subscription[]
				{
					new Subscription{Id = 1, CourseId = 1, UserId = "100000882665737", Rate = 3.5 },
					new Subscription{Id = 2, CourseId = 2, UserId = "100000882665737", Rate = 4.5 },
					new Subscription{Id = 2, CourseId = 3, UserId = "100000882665737", Rate = 4.5 }
				};
			}
		}

	}
}