using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppfinalMvcMarch3.Data;
using WebAppfinalMvcMarch3.Models;

namespace WebAppfinalMvcMarch3.Controllers
{
    public class InterviewSchedulesController : Controller
    {
      
        private readonly TechsDbContext _dbContext = new TechsDbContext();

        // GET: InterviewSchedule
        public ActionResult Index()
        {
            var schedules = _dbContext.InterviewSchedules.ToList();
            return View(schedules);
        }

        // GET: InterviewSchedule/Details
        public ActionResult Details(int id)
        {
            var schedule = _dbContext.InterviewSchedules.Find(id);
            if (schedule == null)
                return HttpNotFound();

            return View(schedule);
        }

        // GET: InterviewSchedule/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterviewSchedule/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InterviewSchedule schedule)
        {
            if (ModelState.IsValid)
            {
                _dbContext.InterviewSchedules.Add(schedule);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schedule);
        }

        // GET: InterviewSchedule/Edit/5
        public ActionResult Edit(int id)
        {
            var schedule = _dbContext.InterviewSchedules.Find(id);
            if (schedule == null)
                return HttpNotFound();

            return View(schedule);
        }

        // POST: InterviewSchedule/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InterviewSchedule schedule)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(schedule).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(schedule);
        }

        // GET: InterviewSchedule/Delete
        public ActionResult Delete(int id)
        {
            var schedule = _dbContext.InterviewSchedules.Find(id);
            if (schedule == null)
                return HttpNotFound();

            return View(schedule);
        }

        // POST: InterviewSchedule/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var schedule = _dbContext.InterviewSchedules.Find(id);
            if (schedule == null)
                return HttpNotFound();

            _dbContext.InterviewSchedules.Remove(schedule);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
