using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using testWeb.Models;

namespace testWeb.Controllers
{
    public class StudentReigstrationController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        // GET: /StudentReigstration/
        public ActionResult Index()
        {
            var studentregistrations = db.StudentRegistrations.Include(s => s.Department);
            return View(studentregistrations.ToList());
        }

        // GET: /StudentReigstration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegistration studentregistration = db.StudentRegistrations.Find(id);
            if (studentregistration == null)
            {
                return HttpNotFound();
            }
            return View(studentregistration);
        }

        // GET: /StudentReigstration/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code");
            return View();
        }

        // POST: /StudentReigstration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="StudentRegistrationId,RegistrationNumber,Name,Email,ContactNumber,Address,Date,DepartmentId")] StudentRegistration studentregistration)
        {
            if (ModelState.IsValid)
            {
                db.StudentRegistrations.Add(studentregistration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", studentregistration.DepartmentId);
            return View(studentregistration);
        }

        // GET: /StudentReigstration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegistration studentregistration = db.StudentRegistrations.Find(id);
            if (studentregistration == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", studentregistration.DepartmentId);
            return View(studentregistration);
        }

        // POST: /StudentReigstration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="StudentRegistrationId,RegistrationNumber,Name,Email,ContactNumber,Address,Date,DepartmentId")] StudentRegistration studentregistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentregistration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", studentregistration.DepartmentId);
            return View(studentregistration);
        }

        // GET: /StudentReigstration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentRegistration studentregistration = db.StudentRegistrations.Find(id);
            if (studentregistration == null)
            {
                return HttpNotFound();
            }
            return View(studentregistration);
        }

        // POST: /StudentReigstration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentRegistration studentregistration = db.StudentRegistrations.Find(id);
            db.StudentRegistrations.Remove(studentregistration);
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
