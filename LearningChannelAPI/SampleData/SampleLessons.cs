using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleLessons
	{
		public static List<Lesson> sampleLessons;
		private static Lesson introduction, lesson1, lesson2,
			lesson3, conclusion;

		public static void AddLessons(List<Lesson> lessons, Course course)
		{
			sampleLessons = new List<Lesson>();
			sampleLessons.Add(introduction = new Lesson
			{
				CourseId = course.Id,
				Title = course.Title + " - Introduction",
			});
			sampleLessons.Add(lesson1 = new Lesson
			{
				CourseId = course.Id,
				Title = course.Title + " - Lesson 1",
			});
			sampleLessons.Add(lesson2 = new Lesson
			{
				CourseId = course.Id,
				Title = course.Title + " - Lesson 2",
			});
			sampleLessons.Add(lesson3 = new Lesson
			{
				CourseId = course.Id,
				Title = course.Title + " - Lesson 3",
			});
			sampleLessons.Add(conclusion = new Lesson
			{
				CourseId = course.Id,
				Title = course.Title + " - Conclusion",
			});
			lessons.Clear();
			lessons.AddRange(sampleLessons);
		}
	}
}