using DavieCleaningService_OfficeMaster.extensions;
using DavieCleaningService_OfficeMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DavieCleaningService_OfficeMaster.Controllers
{
    public class AdminController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //GET: Admin/Employee
        public ActionResult Employees()
        {
            List<Employee> Employees = db.Employees.Where(e => e.Id > 0).ToList();

            return View(Employees);
        }

        //GET: Admin/AddEmployee
        public ActionResult AddEmployee()
        {
            ViewModels.AddEmployeeViewModel AddEmployeeViewModel = new ViewModels.AddEmployeeViewModel() {
                Positions = db.Positions.Where(p => p.Id > 0).ToList()
            };

            return View(AddEmployeeViewModel);
        }

        //POST: Admin/AddEmployee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddEmployee([Bind(Include = "FirstName,LastName,BirthDate,PayRate,PositionId,StartDate,Email")] Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                newEmployee.EmployeeId = EmployeeCodeGenerator.CreateEmployeeCode();
                db.Employees.Add(newEmployee);
                await db.SaveChangesAsync();

                return RedirectToAction("Employees","Admin");
            }

            return View(newEmployee);
        }
    }
}