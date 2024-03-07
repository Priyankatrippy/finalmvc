using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppfinalMvcMarch3.Data;
using WebAppfinalMvcMarch3.Models;

namespace WebAppfinalMvcMarch3.Controllers
{
    public class CandidateController : Controller
    {
        
        private readonly TechsDbContext _dbContext = new TechsDbContext();

        // GET: Candidate
        public ActionResult Index()
        {
            var candidates = _dbContext.Candidates.ToList();
            return View(candidates);
        }

        // GET: Candidate/Details
        public ActionResult Details(int id)
        {
            var candidate = _dbContext.Candidates.Find(id);
            if (candidate == null)
                return HttpNotFound();

            return View(candidate);
        }

        // GET: Candidate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Candidate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Candidates.Add(candidate);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidate);
        }

        // GET: Candidate/Edit
        public ActionResult Edit(int id)
        {
            var candidate = _dbContext.Candidates.Find(id);
            if (candidate == null)
                return HttpNotFound();

            return View(candidate);
        }

        // POST: Candidate/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(candidate).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(candidate);
        }

        // GET: Candidate/Delete
        public ActionResult Delete(int id)
        {
            var candidate = _dbContext.Candidates.Find(id);
            if (candidate == null)
                return HttpNotFound();

            return View(candidate);
        }

        // POST: Candidate/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var candidate = _dbContext.Candidates.Find(id);
            if (candidate == null)
                return HttpNotFound();

            _dbContext.Candidates.Remove(candidate);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
