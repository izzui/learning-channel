using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.DataAccess
{
	public class LessonVideoDal
	{
		public static LessonVideo[] LessonsVideos
		{
			get
			{
				return new LessonVideo[]
				{
					new LessonVideo{LessonsId = 1, VideoId = 1},
					new LessonVideo{LessonsId = 2, VideoId = 2},
					new LessonVideo{LessonsId = 2, VideoId = 3},
					new LessonVideo{LessonsId = 2, VideoId = 4},
					new LessonVideo{LessonsId = 3, VideoId = 5},
					new LessonVideo{LessonsId = 3, VideoId = 6},
					new LessonVideo{LessonsId = 3, VideoId = 7},
					new LessonVideo{LessonsId = 3, VideoId = 8},
					new LessonVideo{LessonsId = 4, VideoId = 9},
					new LessonVideo{LessonsId = 4, VideoId = 10},
					new LessonVideo{LessonsId = 4, VideoId = 11},
					new LessonVideo{LessonsId = 5, VideoId = 12},
					new LessonVideo{LessonsId = 5, VideoId = 13},
					new LessonVideo{LessonsId = 5, VideoId = 14},
					new LessonVideo{LessonsId = 6, VideoId = 15},
					new LessonVideo{LessonsId = 6, VideoId = 16},
					new LessonVideo{LessonsId = 7, VideoId = 17},
					new LessonVideo{LessonsId = 7, VideoId = 18},
					new LessonVideo{LessonsId = 8, VideoId = 19},
					new LessonVideo{LessonsId = 8, VideoId = 20},
					new LessonVideo{LessonsId = 9, VideoId = 21},
				};
			}
		}

	}
}