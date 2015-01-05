using MongoDB.Driver;
using Planru.Crosscutting.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planru.DistributedServices.WebAPI
{
    public class IoCConfig
    {
        private static Lazy<IContainer> container = new Lazy<IContainer>(() =>
        {
            var container = ContainerFactory.CreateContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IContainer container)
        {
            // Temporarily config for testing
            var credential = MongoCredential.CreateMongoCRCredential("planru_system", "liepnguyen", "@dmin348");

            var settings = new MongoClientSettings
            {
                Credentials = new[] { credential },
                Server = new MongoServerAddress("ds055680.mongolab.com", 55680)
            };

            var client = new MongoClient(settings);
            var server = client.GetServer();
            var database = server.GetDatabase("planru_system");


        }
    }
}