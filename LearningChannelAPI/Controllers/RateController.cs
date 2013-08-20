using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Controllers
{
    public class RateController : ApiController
    {
		[HttpGet]
		public double Get(int id, int userId)
		{
			var subscription = SubscriptionDal.Subscriptions.SingleOrDefault(s => s.CourseId == id && s.UserId.Equals(userId));
			if (subscription == null) {
				throw ApiException.CreateException(HttpStatusCode.BadRequest, "User is not enrolled.",
					"You must enroll in course");
			}
			
			return subscription.Rate;
		}
    }
}
