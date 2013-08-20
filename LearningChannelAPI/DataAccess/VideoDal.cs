using System;
using System.Collections.Generic;
using System.Linq;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.DataAccess
{
	public class VideoDal
	{

		// Dados Fakes
		public static IEnumerable<Video> Videos
		{
			get
			{
				return new Video[]
				{
					new Video {Id = 1, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 2, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 3, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 4, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 5, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 6, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 7, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 8, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 9, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 10, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 11, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 12, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 13, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 14, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 15, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 16, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 17, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 18, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 19, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 20, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
					new Video {Id = 21, Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Url = "//www.youtube.com/embed/4ukpG_iPx1Q"},
				};
			}
		}
	}
}