using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{

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


        private readonly ApplicationDbContext _context;
        public PersonController(ApplicationDbContext context);
        public async Task<IActionResult> Index()
        
    }

    [Table("persons")]
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }

}
