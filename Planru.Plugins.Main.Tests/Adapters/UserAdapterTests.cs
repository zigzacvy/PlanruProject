using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Planru.Crosscutting.Adapter;
using Planru.Plugins.Main.Domain;
using Planru.Plugins.Main.Services.DTOs;
using Planru.Crosscutting.NetFramework.Adapter;

namespace Planru.Plugins.Main.Tests.Adapter
{
    [TestClass]
    public class UserAdapterTests
    {
        [TestMethod]
        public void AdaptUserToUserDTO()
        {
            User user = new User() { FirstName = "Liep", LastName = "Nguyen" };
            ITypeAdapter adapter = TypeAdapterFactory.CreateAdapter();
            UserDTO userDTO = adapter.Adapt<User, UserDTO>(user);

            Assert.AreEqual(user.Id, userDTO.Id);
            Assert.AreEqual(user.LastName, userDTO.LastName);
            Assert.AreEqual(user.FirstName, userDTO.FirstName);
        }
    }
}
