using MongoDB.Bson;
using MongoDB.Driver;
using Planru.Core.Persistence;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Planru.Core.Persistence.MongoDB;
using Planru.Plugins.Directory.Persistence.Repositories;
using Planru.Plugins.Directory.Domain;
using Planru.Crosscutting.IoC;
using Planru.Crosscutting.IoC.Unity;
using Planru.Plugins.Directory.Services;
using Planru.Plugins.Directory.Persistence.MongoDB.Repositories;
using Planru.Plugins.Directory.Persistence.MongoDB.Domain;

namespace Planru.Research.MongoDB.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var credential = MongoCredential.CreateMongoCRCredential("planru_system", "liepnguyen", "@dmin348");

            var settings = new MongoClientSettings
            {
                Credentials = new[] { credential },
                Server = new MongoServerAddress("ds055680.mongolab.com", 55680)
            };

            var client = new MongoClient(settings);
            var server = client.GetServer();
            var database = server.GetDatabase("planru_system");

            var userCollection = database.GetCollection<User>("Users");

            //var users = new List<User>();
            //for (int i = 0; i < 20000; i++)
            //{
            //    User user = new User();
            //    user.FirstName = "Liep";
            //    user.LastName = "Nguyen";

            //    users.Add(user);
            //}

            //userCollection.InsertBatch(users);

            // Create new User repository
            //IUserRepository userRepository = new UserRepository("users");

            

            //userCollection.Save(user);

            IContainer container = new UnityContainer();
            container.RegisterInstance<MongoDatabase>(database);
            container.Register<IUserRepository, UserRepository>();

            

            //var userSvc = container.Resolve<IUserService>();

            var userRepos = container.Resolve<IUserRepository>();

            var e = userRepos.Get(new Guid("481ac111-a0ae-0848-8e11-bf06cb0cf66c"));


            //var db = container.Resolve<MongoDatabase>();

            

            System.Console.ReadKey();
        }
    }
}
