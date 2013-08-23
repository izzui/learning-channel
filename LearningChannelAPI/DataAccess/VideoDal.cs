﻿using System;
using System.Collections.Generic;
using System.Linq;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;
using Microsoft.Ajax.Utilities;

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
					new Video {Id = 1, LessonId = 1, Order = 1, NextId = 2, Progress = EnumProgress.completed, Title = "Video 1 Title", Thumb = "thumb-lesson-_0001_Layer 1.jpg", Type = VideoType.Html5, Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00", Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList()},
					new Video {Id = 2, LessonId = 2, Order = 1, PreviousId = 1, NextId = 3, Progress = EnumProgress.completed, Title = "Video 2 Title", Thumb = "thumb-lesson-_0002_Layer 2.jpg", Type = VideoType.Youtube, Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00", Url = "https://youtu.be/QgIrUIgdT-w"},
					new Video {Id = 3, LessonId = 2, Order = 2, PreviousId = 2, NextId = 4, Progress = EnumProgress.completed, Title = "Video 3 Title", Thumb = "thumb-lesson-_0003_Layer 3.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 4, LessonId = 2, Order = 3, PreviousId = 3, NextId = 5, Progress = EnumProgress.inProgress, Title = "Video 4 Title", Thumb = "thumb-lesson-_0004_Layer 4.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 5, LessonId = 3, Order = 1, PreviousId = 4, NextId = 6, Progress = EnumProgress.notStarted, Title = "Video 5 Title", Thumb = "thumb-lesson-_0005_Layer 5.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 6, LessonId = 3, Order = 2, PreviousId = 5, NextId = 7, Progress = EnumProgress.notStarted, Title = "Video 6 Title", Thumb = "thumb-lesson-_0006_Layer 6.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 7, LessonId = 3, Order = 3, PreviousId = 6, NextId = 8, Progress = EnumProgress.inProgress, Title = "Video 7 Title", Thumb = "thumb-lesson-_0007_Layer 7.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 8, LessonId = 3, Order = 4, PreviousId = 7, Progress = EnumProgress.completed, Title = "Video 8 Title", Thumb = "thumb-lesson-_0008_Layer 8.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 9, LessonId = 4, Order = 1, NextId =10 , Progress = EnumProgress.notStarted, Title = "Video 9 Title", Thumb = "thumb-lesson-_0009_Layer 9.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 10, LessonId = 4, Order = 2, PreviousId = 9, NextId = 11, Progress = EnumProgress.completed, Title = "Video 10 Title", Thumb = "thumb-lesson-_0010_Layer 10.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 11, LessonId = 4, Order = 3, PreviousId = 10, NextId = 12, Progress = EnumProgress.inProgress, Title = "Video 11 Title", Thumb = "thumb-lesson-_0011_Layer 11.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 12, LessonId = 5, Order = 1, PreviousId = 11, NextId = 13, Progress = EnumProgress.completed, Title = "Video 12 Title", Thumb = "thumb-lesson-_0012_Layer 12.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 13, LessonId = 5, Order = 2, PreviousId = 12, NextId = 14, Progress = EnumProgress.completed, Title = "Video 13 Title", Thumb = "thumb-lesson-_0013_Layer 13.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 14, LessonId = 5, Order = 3, PreviousId = 13, NextId = 15, Progress = EnumProgress.completed, Title = "Video 14 Title", Thumb = "thumb-lesson-_0014_Layer 14.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 15, LessonId = 6, Order = 1, PreviousId = 14, NextId = 16, Progress = EnumProgress.inProgress, Title = "Video 15 Title", Thumb = "thumb-lesson-_0015_Layer 15.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"},
					new Video {Id = 16, LessonId = 6, Order = 2, PreviousId = 15, Progress = EnumProgress.notStarted, Title = "Video 16 Title", Thumb = "thumb-lesson-_0016_Layer 16.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=QgIrUIgdT-w", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:00"}
				};
			}
		}
	}
}