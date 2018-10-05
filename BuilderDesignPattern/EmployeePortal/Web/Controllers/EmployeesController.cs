using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web.Builder.ConcreteBuilder;
using Web.Builder.Director;
using Web.Builder.IBuilder;
using Web.Factory.AbstractFactory;
using Web.Factory.FactoryMethod;
using Web.Managers;
using Web.Models;

namespace Web.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeePortalEntities db = new EmployeePortalEntities();

        [HttpGet]
        public ActionResult BuildSystem(int? employeeID)
        {
            Employee employee = db.Employees.Find(employeeID);
            if (employee.ComputerDetails.Contains("Laptop"))
                return View("BuildLaptop", employeeID);
            else
                return View("BuildDesktop", employeeID);
        }

        [HttpPost]
        public ActionResult BuildLaptop(FormCollection formCollection)
        {
            Employee employee = db.Employees.Find(Convert.ToInt32(formCollection["employeeID"]));
            ISystemBuilder systemBuilder = new LaptopBuilder();
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.BuildSystem(systemBuilder, formCollection);

            ComputerSystem computerSystem = systemBuilder.GetComputerSystem();
            employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDDSize : {1}, KeyBoard : {2}, Mouse : {3}, TouchScreen : {4}",
                computerSystem.RAM, computerSystem.HDDSize, computerSystem.KeyBoard, computerSystem.Mouse, computerSystem.TouchScreen);

            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult BuildDesktop(FormCollection  formCollection)
        {
            Employee employee = db.Employees.Find(Convert.ToInt32(formCollection["employeeID"]));
            ISystemBuilder systemBuilder = new DesktopBuilder();
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.BuildSystem(systemBuilder, formCollection);

            ComputerSystem computerSystem = systemBuilder.GetComputerSystem();
            employee.SystemConfigurationDetails = string.Format("RAM : {0}, HDDSize : {1}, KeyBoard : {2}, Mouse : {3}, TouchScreen : {4}",
                computerSystem.RAM, computerSystem.HDDSize, computerSystem.KeyBoard, computerSystem.Mouse, computerSystem.TouchScreen);

            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult BuildSystem(int employeeID, string RAM, string HDDSize)
        //{
        //    Employee employee = db.Employees.Find(employeeID);
        //    ComputerSystem computerSystem = new ComputerSystem();
        //    employee.SystemConfigurationDetails = computerSystem.Build();
        //    db.Entry(employee).State = EntityState.Modified;
        //     db.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Employee_Type);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeTypeID = new SelectList(db.Employee_Type, "Id", "EmployeeType");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,JobDescription,Number,Department,HourlyPay,Bonus,EmployeeTypeID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                BaseEmployeeFactory employeeManagerFactory = new EmployeeManagerFactory().CreateFactory(employee);
                //IEmployeeManager empManager = employeeManagerFactory.GetEmployeeManager(employee.EmployeeTypeID);
                //employee.Bonus = empManager.GetBonus();
                //employee.HourlyPay = empManager.GetPay();
                employeeManagerFactory.ApplySalary();
                IComputerFactory computerFactory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager employeeSystemManager = new EmployeeSystemManager(computerFactory);
                employee.ComputerDetails = employeeSystemManager.GetSystemDetails();
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeTypeID = new SelectList(db.Employee_Type, "Id", "EmployeeType", employee.EmployeeTypeID);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeTypeID = new SelectList(db.Employee_Type, "Id", "EmployeeType", employee.EmployeeTypeID);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,JobDescription,Number,Department,HourlyPay,Bonus,EmployeeTypeID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeTypeID = new SelectList(db.Employee_Type, "Id", "EmployeeType", employee.EmployeeTypeID);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
