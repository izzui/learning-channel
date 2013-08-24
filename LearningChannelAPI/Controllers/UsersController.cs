using LearningChannelAPI.Models;
using System.Web.Http;

namespace LearningChannelAPI.Controllers
{
	public class UsersController : ApiController
	{
		[HttpGet]
		public User Get(string id)
		{
			return null;
		}

		//[HttpPost]
		//public void Post([FromBody] string value)
		//{

		//}
	}
}