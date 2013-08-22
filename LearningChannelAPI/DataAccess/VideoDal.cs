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
					new Video {Id = 1, Title = "Video 1 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg", Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList()},
					new Video {Id = 2, Title = "Video 2 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 3, Title = "Video 3 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 4, Title = "Video 4 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 5, Title = "Video 5 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 6, Title = "Video 6 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 7, Title = "Video 7 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 8, Title = "Video 8 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 9, Title = "Video 9 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 10, Title = "Video 10 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 11, Title = "Video 11 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 12, Title = "Video 12 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 13, Title = "Video 13 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 14, Title = "Video 14 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 15, Title = "Video 15 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 16, Title = "Video 16 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 17, Title = "Video 17 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 18, Title = "Video 18 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 19, Title = "Video 19 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 20, Title = "Video 20 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
					new Video {Id = 21, Title = "Video 21 Title", Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg"},
				};
			}
		}
	}
}