using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppfinalMvcMarch3.Data;
using WebAppfinalMvcMarch3.Models;

namespace WebAppfinalMvcMarch3.Controllers
{
    public class PanelMembersController : Controller
    {
        TechsDbContext db = new TechsDbContext();
        // GET: PanelMembers
        public ActionResult Index()
        {
            return View(db.PanelMembers.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        // PanelMembers:-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PanelMember panelMember)
        {
            if (ModelState.IsValid)
            {
                db.PanelMembers.Add(panelMember);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(panelMember);
        }
        //PanelMember:-Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PanelMember panelMember = db.PanelMembers.Find(id);
            if (panelMember == null)
            {
                return HttpNotFound();
            }
            return View(panelMember);
        }
        //PanelMember:-Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PanelMember panelMember = db.PanelMembers.Find(id);
            if (panelMember == null)
            {
                return HttpNotFound();
            }
            return View(panelMember);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PanelMember panelMember)
        {
            if (ModelState.IsValid)
            {
                db.Entry(panelMember).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(panelMember);
        }
        //Delete
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PanelMember panelMember = db.PanelMembers.Find(id);
            if (panelMember == null)
            {
                return HttpNotFound();
            }
            return View(panelMember);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PanelMember panelMember = db.PanelMembers.Find(id);
            db.PanelMembers.Remove(panelMember);
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