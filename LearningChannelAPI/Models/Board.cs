using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningChannelAPI.Models
{
	public class Board
	{
		public string Username { get; set; }
		public int Score { get; set; }
		public DateTime Date { get; set; }
		public string Thumb { get; set; }
	}
}