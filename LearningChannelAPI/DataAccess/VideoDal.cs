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
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 1},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 1},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 2},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 2},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 3},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 3},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 4},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 4},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 4},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 4},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 5},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 5},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 6},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 7},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 7},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 7},
					new Video {Id = 1, Thumb = "/videos/1.png", Url = "http://youtube.com/video1", LessonId = 8},
					new Video {Id = 2, Thumb = "/videos/2.png", Url = "http://youtube.com/video2", LessonId = 9},
				};
			}
		}
	}
}