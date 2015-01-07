﻿using MongoDB.Bson;
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
using MongoDB.Bson.Serialization;
using Planru.Core.Domain;
using System.Linq.Expressions;
using AutoMapper;
using Planru.Plugins.Directory.Services.DTOs;
using Planru.Crosscutting.Adapter.Automapper;
using Planru.Crosscutting.Adapter;

namespace Planru.Research.MongoDB.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ForMember<int, int>(d => d.GetType(), m => m.MapForm(s => s.GetType()));

            //Mapper.CreateMap<User, UserDTO>().ForMember(d => d.FirstName, m => m.MapFrom(s => s.LastName));
            //Mapper.CreateMap<User, UserDTO>().ForMember(d => d.LastName, m => m.MapFrom(s => s.FirstName));

            //AutomapperTypeAdapter a = new AutomapperTypeAdapter();
            //a.CreateMap<User, UserDTO>()
            //    .ForMember(d => d.FirstName, m => m.MapFrom(s => s.LastName))
            //    .ForMember(d => d.LastName, m => m.MapFrom(s => s.FirstName));

            //User user = new User() { FirstName = "Liep", LastName = "Nguyen" };
            //var userDto = a.Adapt<UserDTO>(user);

           

            var credential = MongoCredential.CreateMongoCRCredential("planru_system", "liepnguyen", "@dmin348");

            var settings = new MongoClientSettings
            {
                Credentials = new[] { credential },
                Server = new MongoServerAddress("ds055680.mongolab.com", 55680)
            };

            var client = new MongoClient(settings);
            var server = client.GetServer();
            var database = server.GetDatabase("planru_system");

            ITypeAdapter typeAdapter = new AutomapperTypeAdapter();

            IContainer container = new UnityContainer();
            container.RegisterInstance<MongoDatabase>(database);
            container.RegisterInstance<ITypeAdapter>(typeAdapter);
            container.Register<IUserRepository, UserRepository>();
            container.Register<IUserService, UserService>();

            typeAdapter.CreateMap<User, UserDTO>();
            typeAdapter.CreateMap<UserDTO, User>();

            var userService = container.Resolve<IUserService>();
            //userService.Add(new UserDTO() { Id = Guid.NewGuid(), FirstName = "Liep", LastName = "Nguyen" });

            for (int i = 0; i < 100; i++)
            {
                var user = new UserDTO()
                {
                    Id = Guid.NewGuid(),
                    DisplayName = "Liep Nguyen",
                    FirstName = "Liep",
                    LastName = "Nguyen"
                };

                userService.Add(user);
            }

            //var userCollection = database.GetCollection<User>("Users");

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

            

            //var userSvc = container.Resolve<IUserService>();

            

            //var userRepos = container.Resolve<IUserRepository>();

            //var e = userRepos.Get(new Guid("e788e49e-58ab-43f4-98cd-be8d02f26c3a"));

            //var users = userRepos.GetAll();

            //userRepos.Add(new User() { FirstName = "Mien", LastName = "Tran" });

            //var db = container.Resolve<MongoDatabase>();

            System.Console.ReadKey();
        }
    }
}
