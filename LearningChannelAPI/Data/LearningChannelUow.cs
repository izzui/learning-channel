using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearningChannelAPI.Models;

namespace LearningChannelAPI.Data
{
	public class LearningChannelUow
	{
		public LearningChannelUow 

		// Repositories
		

		protected void CreateDbContext()
		{
			DbContext = new LearningChannelContext();

			// Do NOT enable proxied entities, else serialization fails
			DbContext.Configuration.ProxyCreationEnabled = false;

			// Load navigation properties explicitly (avoid serialization trouble)
			DbContext.Configuration.LazyLoadingEnabled = false;

			// Because Web API will perform validation, we don't need/want EF to do so
			DbContext.Configuration.ValidateOnSaveEnabled = false;

			//DbContext.Configuration.AutoDetectChangesEnabled = false;
			// We won't use this performance tweak because we don't need 
			// the extra performance and, when autodetect is false,
			// we'd have to be careful. We're not being that careful.
		}

		private LearningChannelContext DbContext { get; set; }
	}
}