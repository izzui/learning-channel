using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using LearningChannelAPI.DataAccess;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Controllers
{
	public class BoardController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<Board> Get()
		{
			bool lastMonth = false;
			var request = Request.RequestUri.ParseQueryString().Get("lastMonth");

			if (request != null)
				lastMonth = bool.Parse(request);

			return BoardDal.Scores.Where(b => (b.Date > DateTime.Now.AddDays(-8) || !lastMonth));

		}
	}
}