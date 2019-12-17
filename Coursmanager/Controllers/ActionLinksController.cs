using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coursmanager.Models;

namespace Coursmanager.Controllers
{
    public class ActionLinksController : Controller
    {
        private CourseManagerContext db = new CourseManagerContext();

        // GET: ActionLinks
        public ActionResult Index()
        {
            return View(db.ActionLink.ToList());
        }

        // GET: ActionLinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLink actionLink = db.ActionLink.Find(id);
            if (actionLink == null)
            {
                return HttpNotFound();
            }
            return View(actionLink);
        }

        // GET: ActionLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ActionLinks/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Controller,Action")] ActionLink actionLink)
        {
            if (ModelState.IsValid)
            {
                db.ActionLink.Add(actionLink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionLink);
        }

        // GET: ActionLinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLink actionLink = db.ActionLink.Find(id);
            if (actionLink == null)
            {
                return HttpNotFound();
            }
            return View(actionLink);
        }

        // POST: ActionLinks/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] ActionLink actionLink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionLink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionLink);
        }

        // GET: ActionLinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionLink actionLink = db.ActionLink.Find(id);
            if (actionLink == null)
            {
                return HttpNotFound();
            }
            return View(actionLink);
        }

        // POST: ActionLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ActionLink actionLink = db.ActionLink.Find(id);
            db.ActionLink.Remove(actionLink);
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
