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
					new Video {Id = 1, LessonId = 1, Order = 1, NextId = 2, Progress = EnumProgress.completed, Title = "Video 1 Title", Thumb = "https://local-learningchannel.izzui.com/oceans-clip.png", Type = VideoType.Regular, Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList()},
					new Video {Id = 2, LessonId = 2, Order = 1, PreviousId = 1, NextId = 3, Progress = EnumProgress.completed, Title = "Video 2 Title", Type = VideoType.Youtube, Url = "https://youtu.be/QgIrUIgdT-w"},
					new Video {Id = 3, LessonId = 2, Order = 2, PreviousId = 2, NextId = 4, Progress = EnumProgress.completed, Title = "Video 3 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 4, LessonId = 2, Order = 3, PreviousId = 3, NextId = 5, Progress = EnumProgress.inProgress, Title = "Video 4 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 5, LessonId = 3, Order = 1, PreviousId = 4, NextId = 6, Progress = EnumProgress.notStarted, Title = "Video 5 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 6, LessonId = 3, Order = 2, PreviousId = 5, NextId = 7, Progress = EnumProgress.notStarted, Title = "Video 6 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 7, LessonId = 3, Order = 3, PreviousId = 6, NextId = 8, Progress = EnumProgress.inProgress, Title = "Video 7 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 8, LessonId = 3, Order = 4, PreviousId = 7, Progress = EnumProgress.completed, Title = "Video 8 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 9, LessonId = 4, Order = 1, NextId =10 , Progress = EnumProgress.notStarted, Title = "Video 9 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 10, LessonId = 4, Order = 2, PreviousId = 9, NextId = 11, Progress = EnumProgress.completed, Title = "Video 10 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 11, LessonId = 4, Order = 3, PreviousId = 10, NextId = 12, Progress = EnumProgress.inProgress, Title = "Video 11 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 12, LessonId = 5, Order = 1, PreviousId = 11, NextId = 13, Progress = EnumProgress.completed, Title = "Video 12 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 13, LessonId = 5, Order = 2, PreviousId = 12, NextId = 14, Progress = EnumProgress.completed, Title = "Video 13 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 14, LessonId = 5, Order = 3, PreviousId = 13, NextId = 15, Progress = EnumProgress.completed, Title = "Video 14 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 15, LessonId = 6, Order = 1, PreviousId = 14, NextId = 16, Progress = EnumProgress.inProgress, Title = "Video 15 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 16, LessonId = 6, Order = 2, PreviousId = 15, Progress = EnumProgress.notStarted, Title = "Video 16 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 17, LessonId = 7, Order = 1, NextId = 18, Progress = EnumProgress.inProgress, Title = "Video 17 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 18, LessonId = 7, Order = 2, PreviousId = 17, NextId = 19, Progress = EnumProgress.completed, Title = "Video 18 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 19, LessonId = 8, Order = 1, PreviousId = 18, NextId = 20, Progress = EnumProgress.notStarted, Title = "Video 19 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 20, LessonId = 8, Order = 2, PreviousId = 19, NextId = 21, Progress = EnumProgress.notStarted, Title = "Video 20 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
					new Video {Id = 21, LessonId = 9, Order = 1, PreviousId = 20, Progress = EnumProgress.completed, Title = "Video 21 Title", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w"},
				};
			}
		}
	}
}