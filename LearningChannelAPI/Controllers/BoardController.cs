﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.Controllers
{
	public class BoardController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<Board> Get()
		{
			bool lastweek = false;
			var request = Request.RequestUri.ParseQueryString().Get("lastweek");

			if (request != null)
				lastweek = bool.Parse(request);

			return BoardDal.Scores.Where(b => (b.Date > DateTime.Now.AddDays(-8) || !lastweek));

		}
	}
}