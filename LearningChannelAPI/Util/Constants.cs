using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Util
{
	public struct Languages
	{
		public const string AllLanguages = "All_Languages";
		public const string English = "en";
		public const string Portuese = "pt";
		public const string Spanish = "es";
	}

	public struct CoursesSorter
	{
		public const string Title = "Title";
		public const string Views = "Views";
		public const string Subscriptions = "Subscriptions";
		public const string Publishdate = "PublishDate";
	}

	public struct VideoType
	{
		public const string Youtube = "youtube";
		public const string Vimoe = "vimeo";
		public const string Regular = "regular";
	}
}