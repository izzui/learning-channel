using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class VideoSourceDal
	{
		public static IEnumerable<VideoSource> Sources
		{
			get
			{
				return new VideoSource[]
				{
					new VideoSource{Id = 1, VideoId = 1, Url = "http://local-learningchannel.izzui.com/oceans-clip.mp4", Type = "video/mp4"},
					new VideoSource{Id = 2, VideoId = 1, Url = "http://local-learningchannel.izzui.com/oceans-clip.webm", Type = "video/Webm"},
					new VideoSource{Id = 3, VideoId = 1, Url = "http://local-learningchannel.izzui.com/oceans-clip.ogv", Type = "video/ogg"},
				};
			}
		}
	}
}