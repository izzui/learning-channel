using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Board
	{
		public string UserName { get; set; }
		public int Score { get; set; }
		public DateTime Date { get; set; }
	}
}