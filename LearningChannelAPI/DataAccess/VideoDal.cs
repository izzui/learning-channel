using System;
using System.Collections.Generic;
using System.Linq;
using LearningChannelAPI.Models;
using LearningChannelAPI.Util;
using Microsoft.Ajax.Utilities;

namespace LearningChannelAPI.DataAccess
{
	public class VideoDal
	{

		// Dados Fakes
		public static IEnumerable<Video> Videos
		{
			get
			{
				return new Video[]
				{
					new Video {Id = 1, LessonId = 1, Order = 1, NextId = 2, Progress = EnumProgress.completed, Title = "Corte Introdução", Thumb = "http://img.youtube.com/vi/_v0AkGCorvk/2.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=_v0AkGCorvk", Description="Apresentação das técnicas de corte em 5 passos de Master Results ensinadas pelo cabeleireiro da TV, Rodrigo Cintra.", Duration= "1:04", Width = 640, Height = 360, VideosCount = 5, VideosCompleted = 5}, //Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList(), Poster = "/oceans-clip.png"

					new Video {Id = 2, LessonId = 2, Order = 1, NextId = 3, Progress = EnumProgress.completed, Title = "Corte: Cabelo Curto", Thumb = "http://img.youtube.com/vi/2JL3SlTxVBc/2.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=2JL3SlTxVBc", Description="Aprenda a fazer Corte de Cabelo Curto com a técnica de 5 passos de Master Results. Apresentado por Rodrigo Cintra!", Duration= "1:04", Width = 640, Height = 360, VideosCount = 5, VideosCompleted = 5}, //Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList(), Poster = "/oceans-clip.png"
					new Video {Id = 3, LessonId = 2, Order = 2, PreviousId = 2, NextId = 4, Progress = EnumProgress.completed, Title = "Corte: Cabelo Médio", Thumb = "http://img.youtube.com/vi/_v0AkGCorvk/3.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=2JL3SlTxVBc", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "6:13", Width = 640, Height = 360, VideosCount = 5, VideosCompleted = 5},
					new Video {Id = 4, LessonId = 2, Order = 3, PreviousId = 3, Progress = EnumProgress.completed, Title = "Corte: Cabelo Longo", Thumb = "http://img.youtube.com/vi/_v0AkGCorvk/1.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=2JL3SlTxVBc", Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Duration= "5:03", Width = 640, Height = 360, VideosCount = 5, VideosCompleted = 5},

					
					
					
					
					
					
					new Video {Id = 41, LessonId = 41, Order = 1, NextId = 42, Progress = EnumProgress.completed, Title = "Tratamento Introdução", Thumb = "http://img.youtube.com/vi/wzJH-1yTYlc/2.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=wzJH-1yTYlc", Description="Apresentação das técnicas de tratamento em 5 passos de Master Results ensinadas pelo cabeleireiro da TV, Rodrigo Cintra.", Duration= "1:04", Width = 640, Height = 360, VideosCount = 8, VideosCompleted = 5}, //Sources = VideoSourceDal.Sources.Where(vs => vs.VideoId == 1).ToList(), Poster = "/oceans-clip.png"
					
					new Video {Id = 42, LessonId = 42, Order = 1, PreviousId = 41, NextId = 43, Progress = EnumProgress.completed, Title = "Tratamento: Escova de Controle", Thumb = "http://img.youtube.com/vi/N6AOCOEmOuM/2.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=N6AOCOEmOuM", Description="Aprenda Nutrição de Choque com a técnica de 5 passos de Master Results. Tutorial apresentado por Rodrigo Cintra!", Duration= "6:13", Width = 640, Height = 360, VideosCount = 8, VideosCompleted = 5},
					new Video {Id = 43, LessonId = 42, Order = 2, PreviousId = 42, NextId = 44, Progress = EnumProgress.completed, Title = "Tratamento: Nutrição de Choque", Thumb = "http://img.youtube.com/vi/wzJH-1yTYlc/1.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=wzJH-1yTYlc", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.", Duration= "5:03", Width = 640, Height = 360, VideosCount = 8, VideosCompleted = 5},
					new Video {Id = 44, LessonId = 42, Order = 3, PreviousId = 43, Progress = EnumProgress.completed, Title = "Tratamento: Nutrição de Choque", Thumb = "http://img.youtube.com/vi/wzJH-1yTYlc/3.jpg", Type = VideoType.Youtube, Url = "http://www.youtube.com/watch?v=wzJH-1yTYlc", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi viverra viverra massa, mollis commodo orci vehicula ac. Cras sed velit eget enim pellentesque faucibus nec eu mauris.", Duration= "0:33", Width = 640, Height = 360, VideosCount = 8, VideosCompleted = 5}
				};
			}
		}
	}
}