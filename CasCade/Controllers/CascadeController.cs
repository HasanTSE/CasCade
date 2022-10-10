//using CasCade.Data;
using CasCade.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasCade.Controllers
{
    
    public class CascadeController : Controller
    {
        private readonly dbContext _db;
        public CascadeController(dbContext db)
        {
            _db = db;
        }

        //private readonly ApplicationContext context;
        //public CascadeController(ApplicationContext context)
        //{
        //    //this.ControllerContext = context;
        //    this.context = context;
        //}

        public JsonResult Country()
        {
            var cnt = _db.Countries.ToList();
            return new JsonResult(cnt);
        }

        public JsonResult State(int id)
        {
            var st = _db.States.Where(e => e.Country.Id == id).ToList();
            return new JsonResult(st);
        }

        public JsonResult City(int id)
        {
            var ct = _db.Cities.Where(e => e.State.Id == id).ToList();
            return new JsonResult(ct);
        }

        public IActionResult CascadeDropdown()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
