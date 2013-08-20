using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleVideos
	{
		public static List<Video> sampleVideos;
		private static Video introduction, lessonVideo1, lessonVideo2, lessonVideo3, lessonVideo4, conclusion;

		public static void AddVideos(List<Video> videos, Lesson lesson)
		{
			sampleVideos = new List<Video>();
			if (lesson.Title.Contains("Introduction"))
			{
				sampleVideos.Add(introduction = new Video
				{
					LessonId = lesson.Id,
					Thumb = "//img.youtube.com/vi/4ukpG_iPx1Q/0.jpg",
					Url = "//www.youtube.com/embed/4ukpG_iPx1Q"
				});
			}
			else if (lesson.Title.Contains("Conclusion"))
			{
				sampleVideos.Add(lessonVideo1 = new Video
				{
					LessonId = lesson.Id,
					Thumb = "/thumbVideos/conclusionVideo.png",
					Url = "//www.youtube.com/embed/0Dt8ZFihbno"
				});
			}
			else
			{
				sampleVideos.Add(lessonVideo1 = new Video
				{
					LessonId = lesson.Id,
					Thumb = "/thumbVideos/conclusionVideo.png",
					Url = "//www.youtube.com/embed/lKJXuMvuVy8"
				});
				sampleVideos.Add(lessonVideo2 = new Video
				{
					LessonId = lesson.Id,
					Thumb = "/thumbVideos/lessonVideo2.png",
					Url = "//www.youtube.com/embed/lKJXuMvuVy8"
				});
				sampleVideos.Add(lessonVideo3 = new Video
				{
					LessonId = lesson.Id,
					Thumb = "/thumbVideos/lessonVideo3.png",
					Url = "//www.youtube.com/embed/DVUEdJC8j70"
				});
				sampleVideos.Add(lessonVideo4 = new Video
				{
					LessonId = lesson.Id,
					Thumb = "/thumbVideos/lessonVideo4.png",
					Url = "//www.youtube.com/embed/NZb0XKHgtjo"
				});
			}
			videos.Clear();
			videos.AddRange(sampleVideos);
		}
	}
}