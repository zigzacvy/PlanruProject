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
using System.Net.Http;
using System.Net;

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

        public IEnumerable<UserDTO> Get()
        {
            return _userService.GetAll();
        }

        public IHttpActionResult Get(Guid id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        public IHttpActionResult Post(UserDTO user)
        {
            _userService.Add(user);
            return Created<UserDTO>(Url.Link("DefaultApi", new { id = user.Id }), user);
        }

        public void Put(UserDTO user)
        {
            _userService.Modify(user);
        }

        public void Delete(Guid id)
        {
            _userService.Remove(id);
        }
    }
}
