using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;

namespace LearningChannelAPI.SampleData
{
	public static class SampleAuthors
	{
		public static List<Author> sampleAuthors;
		private static Author Vicente, Bernardo, Henrique,
			Roberto, Demetrius, Andrey;

		public static void AddAuthors(List<Author> authors)
		{

			var descriptionTextGenerator = new SampleTextGenerator();
            const SampleTextGenerator.SourceNames bioTextSource =
                SampleTextGenerator.SourceNames.ChildHarold;
			int countSentences = 10;
			sampleAuthors = new List<Author>();
			sampleAuthors.Add(Vicente = new Author
			{
				Name = "Vicente d'Avila Melo Sarmento",
				FacebookId = "1199458233",
				Title = "Arquiteto da Informação",
				LinkedIn = "58230796",
				GooglePlus = "116134093095093079398",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "vicente.sarmento@izzui.com"
			});
			sampleAuthors.Add(Bernardo = new Author
			{
				Name = "Bernardo Leite Pereira Castanheira",
				FacebookId = "100002094308007",
				Title = "Analista Pleno",
				LinkedIn = "91197116",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "bernardo.castanheira@izzui.com"
			});
			sampleAuthors.Add(Roberto = new Author
			{
				Name = "Roberto Barreto de Melo Campos",
				FacebookId = "100000882665737",
				Title = "Analista Pleno",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "roberto.campos@izzui.com"
			});
			sampleAuthors.Add(Henrique = new Author
			{
				Name = "Henrique Rabello",
				FacebookId = "100001245811711",
				Title = "Analista Sênior",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "henrique.rabello@izzui,com"
			});
			sampleAuthors.Add(Andrey = new Author
			{
				Name = "Andrey Britto",
				FacebookId = "100000856290659",
				Title = "Analista Sênior",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "andrey.britto@izzui.com"
			});
			sampleAuthors.Add(Demetrius = new Author
			{
				Name = "Demetrius Nunes",
				FacebookId = "790128571",
				Title = "Chief Technology Officer",
				Description = descriptionTextGenerator.GenSentences(countSentences, bioTextSource),
				Email = "demetrius.nunes@izzui.com"
			});

			authors.AddRange(sampleAuthors);
		}
	}
}