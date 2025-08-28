using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

    public class PersonController : Controller
    {
    
        public IActionResult Index()
        {
            ViewBag.Message = "Nhan du lieu";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.Message = ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            return View();
        }
    }

