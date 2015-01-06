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
        public IEnumerable<UserDTO> Get()
        {
            return _userService.GetAll();
        }

        // GET api/values/5
        public IHttpActionResult Get(Guid id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // POST api/values
        public void Post(UserDTO user)
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
