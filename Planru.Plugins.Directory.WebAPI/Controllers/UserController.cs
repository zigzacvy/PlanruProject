using Planru.Core.Persistence;
using Planru.Crosscutting.Adapter;
using Planru.Plugins.Directory.Domain;
using Planru.Plugins.Directory.Persistence;
using Planru.Plugins.Directory.Persistence.Repositories;
using Planru.Plugins.Directory.Services;
using Planru.Plugins.Directory.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Planru.Plugins.Directory.WebAPI.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService;
        private ITypeAdapter _typeAdapter;

        public UserController(ITypeAdapter typeAdapter, IUserService userService)
        {
            _typeAdapter = typeAdapter;
            _userService = userService;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var user = new User() { FirstName = "Liep", LastName = "Nguyen" };
            var userDto = _typeAdapter.Adapt<UserDTO>(user);

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
