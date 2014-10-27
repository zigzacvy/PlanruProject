using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Planru.Plugins.Main.Persistence.Repositories;
using Planru.Plugins.Main.Persistence.UnitOfWork;
using Planru.Plugins.Main.Domain;

namespace Planru.DistributedServices.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            DefaultUnitOfWork uow = new DefaultUnitOfWork();
            var userRepository = new UserRepository(uow);
            userRepository.Add(new User() { FirstName = "Liep", LastName = "Nguyen" });
            userRepository.UnitOfWork.Commit();

            return View();
        }
    }
}
