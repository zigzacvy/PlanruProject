using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planru.Crosscutting.Adapter;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Services.DTOs;

namespace Planru.Plugins.Directory.Tests.Adapter
{
    [TestClass]
    public class UserAdapterTests
    {
        [TestMethod]
        public void AdaptUserToUserDTO()
        {
            User user = new User() { FirstName = "Liep", LastName = "Nguyen" };
            ITypeAdapter adapter = TypeAdapterFactory.CreateAdapter();

            adapter.CreateMap<User, UserDTO>();

            UserDTO userDTO = adapter.Adapt<User, UserDTO>(user);

            Assert.AreEqual(user.Id, userDTO.Id);
            Assert.AreEqual(user.LastName, userDTO.LastName);
            Assert.AreEqual(user.FirstName, userDTO.FirstName);
        }
    }
}
