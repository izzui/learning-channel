using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningChannelAPI.Controllers;

namespace LearningChannelAPI.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Avatar { get; set; }
	}
}
