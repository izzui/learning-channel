using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleGroups
	{
		public static List<Group> sampleGroups;
		private static Group recentGroup1, recentGroup2, enrolledGroup1, enrolledGroup2, enrolledGroup3, popularGroup1,
			popularGroup2, popularGroup3, popularGroup4;

		public static void AddGroups(List<Group> groups, Course course)
		{
			sampleGroups = new List<Group>();
			if (course.Title.Contains("Recente"))
			{
				sampleGroups.Add(recentGroup1 = new Group
				{
					CourseId = course.Id,
					FacebookId = "153762018156922",
					Name = "Grupo Recente 1"
				});
				sampleGroups.Add(recentGroup2 = new Group
				{
					CourseId = course.Id,
					FacebookId = "501704436588451",
					Name = "Grupo Recente 2"
				});
			}
			else if (course.Title.Contains("Inscrito"))
			{
				sampleGroups.Add(enrolledGroup1 = new Group
				{
					CourseId = course.Id,
					FacebookId = "170758626445591",
					Name = "Grupo Inscrito 1"
				});
				sampleGroups.Add(enrolledGroup2 = new Group
				{
					CourseId = course.Id,
					FacebookId = "443928499056242",
					Name = "Grupo Inscrito 2"
				});
				sampleGroups.Add(enrolledGroup3 = new Group
				{
					CourseId = course.Id,
					FacebookId = "310544465753148",
					Name = "Grupo Inscrito 3"
				});
			}
			else if (course.Title.Contains("Popular"))
			{
				sampleGroups.Add(popularGroup1 = new Group
				{
					CourseId = course.Id,
					FacebookId = "228167353999601",
					Name = "Grupo Popular 1"
				});
				sampleGroups.Add(popularGroup2 = new Group
				{
					CourseId = course.Id,
					FacebookId = "494715230610489",
					Name = "Grupo Popular 2"
				});
				sampleGroups.Add(popularGroup3 = new Group
				{
					CourseId = course.Id,
					FacebookId = "207163149450866",
					Name = "Grupo Popular 3"
				});
				sampleGroups.Add(popularGroup4 = new Group
				{
					CourseId = course.Id,
					FacebookId = "638643722826701",
					Name = "Grupo Popular 4"
				});
			}
			
			groups.Clear();
			groups.AddRange(sampleGroups);
		}
	}
}