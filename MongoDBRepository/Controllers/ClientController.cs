using MongoDBRepository.Entities;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoDBRepository.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/
        static MongoRepository<Employee> ClientRepository = new MongoRepository<Employee>();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            return Json(ClientRepository.ToList(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddEditEmployee(int employeeId)
        {
            if (employeeId > 0)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

    }
}
