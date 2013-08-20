using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleCourseAuthors
	{
		//public static List<CourseAuthor> sampleCourseAuthors;

		public static Dictionary<int, int[]> _courseAuthors
		{
			get
			{
				var list = new Dictionary<int, int[]>();
				list.Add(1, new[] { 1, 2 });
				list.Add(2, new[] { 3 });
				list.Add(3, new[] { 4 });
				list.Add(4, new[] { 5, 6 });
				list.Add(5, new[] { 2 });
				list.Add(6, new[] { 4, 6 });
				list.Add(7, new[] { 1 });
				list.Add(8, new[] { 6 });
				list.Add(9, new[] { 5, 3 });
				return list;
			}
		}

	

		//public static void AddCourseAuthors(List<CourseAuthor> courseAuthors, Course course, List<Author> authors)
		//{
		//	//sampleCourseAuthors = new List<CourseAuthor>();
		//	//foreach (int authorId in _courseAuthors[course.Id])
		//	//{
		//	//	sampleCourseAuthors.Add(new CourseAuthor
		//	//	{
		//	//		CourseId = course.Id,
		//	//		AuthorId = authorId,
		//	//		Created = DateTime.Now
		//	//	});
		//	//}
		//	//courseAuthors.Clear();
		//	//courseAuthors.AddRange(sampleCourseAuthors);
		//}
	}
}