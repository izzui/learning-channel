using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleUsers
	{
		public static List<User> sampleUsers;
		private static User andrey, antonio, bernardo,
			beto, demetrius, fabio, felipe, henrique, 
			renata, roberto, vicente, vladimir;

		public static void AddUsers(List<User> users)
		{
			sampleUsers = new List<User>();
			sampleUsers.Add(andrey = new User
			{
				Avatar = "",
				Email =  "andrey.britto@izzui.com",
				FacebookId = "100000856290659",
				Name = "Andrey Britto"
			});
			sampleUsers.Add(antonio = new User
			{
				Avatar = "",
				Email = "antonio.affonseca@izzui.com",
				FacebookId = "503249903",
				Name = "Antonio Affonseca"
			});
			sampleUsers.Add(bernardo = new User
			{
				Avatar = "",
				Email = "bernardo.castanheira@izzui.com",
				FacebookId = "100002094308007",
				Name = "Bernardo Castanheira"
			});
			sampleUsers.Add(beto = new User
			{
				Avatar = "",
				Email = "beto.lucena@izzui.com",
				FacebookId = "100001461820059",
				Name = "Beto Lucena"
			});
			sampleUsers.Add(demetrius = new User
			{
				Avatar = "",
				Email = "demetrius.nunes@izzui.com",
				FacebookId = "790128571",
				Name = "Demetrius Nunes"
			});
			sampleUsers.Add(fabio = new User
			{
				Avatar = "",
				Email = "fabio.figueiredo@izzui.com",
				FacebookId = "100000354163834",
				Name = "Fabio Figueiredo"
			});
			sampleUsers.Add(felipe = new User
			{
				Avatar = "",
				Email = "felipe.menezes@izzui.com",
				FacebookId = "516479621",
				Name = "Felipe Menezes"
			});
			sampleUsers.Add(henrique = new User
			{
				Avatar = "",
				Email = "henrique.rabelo@izzui.com",
				FacebookId = "100001245811711",
				Name = "Henrique Rabello"
			});
			sampleUsers.Add(renata = new User
			{
				Avatar = "",
				Email = "renata.souza@izzui.com",
				FacebookId = "100001245811711",
				Name = "Renata Souza"
			});

			users.AddRange(sampleUsers);
		}
	}
}