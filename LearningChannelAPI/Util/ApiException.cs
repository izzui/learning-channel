using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearningChannelAPI.Util
{
	public class ApiException
	{
		public static HttpResponseException CreateException(HttpStatusCode code, string reasonPhrase, string content)
		{
			return new HttpResponseException(new HttpResponseMessage(code)
			{
				ReasonPhrase = reasonPhrase,
				Content = new StringContent(content)
			}); 
		}

	}
}