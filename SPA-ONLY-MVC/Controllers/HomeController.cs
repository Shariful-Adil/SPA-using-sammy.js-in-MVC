using SPA_ONLY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPA_ONLY_MVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return PartialView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return PartialView();
        }

        public ActionResult AddEmployee()
        {
           

            return PartialView();
        }


        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(employee);

            Session["Employee"] = Employees;

            return RedirectToAction("EmployeeList");
        }
        public ActionResult EmployeeList()
        {
            var list = Session["Employee"] as List<Employee>;
            return PartialView(list.ToList());
        }
    }
}
