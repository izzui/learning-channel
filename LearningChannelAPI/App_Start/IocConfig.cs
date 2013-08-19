﻿using System.Web.Http;
using Ninject;
using LearningChannelAPI.Data;

namespace LearningChannelAPI
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); // Ninject IoC

            // These registrations are "per instance request".
            // See http://blog.bobcravens.com/2010/03/ninject-life-cycle-management-or-scoping/

			kernel.Bind<LearningChannelContext>().To<LearningChannelContext>();

            kernel.Bind<ILearningChannelRepository>().To<LearningChannelRepository>();
            //kernel.Bind<ICodeCamperUow>().To<CodeCamperUow>();

            // Tell WebApi how to use our Ninject IoC
            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}