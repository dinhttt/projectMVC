using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class ThongtinSuCoesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: ThongtinSuCoes
        public ActionResult Index()
        {
            return View(db.ThongtinSuCos.ToList());
        }

        // GET: ThongtinSuCoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinSuCo thongtinSuCo = db.ThongtinSuCos.Find(id);
            if (thongtinSuCo == null)
            {
                return HttpNotFound();
            }
            return View(thongtinSuCo);
        }

        // GET: ThongtinSuCoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongtinSuCoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThongtinSuCoID,ThongTinSuCoCode,CreateDate")] ThongtinSuCo thongtinSuCo)
        {
            if (ModelState.IsValid)
            {
                db.ThongtinSuCos.Add(thongtinSuCo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thongtinSuCo);
        }

        // GET: ThongtinSuCoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinSuCo thongtinSuCo = db.ThongtinSuCos.Find(id);
            if (thongtinSuCo == null)
            {
                return HttpNotFound();
            }
            return View(thongtinSuCo);
        }

        // POST: ThongtinSuCoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThongtinSuCoID,ThongTinSuCoCode,CreateDate")] ThongtinSuCo thongtinSuCo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongtinSuCo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thongtinSuCo);
        }

        // GET: ThongtinSuCoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinSuCo thongtinSuCo = db.ThongtinSuCos.Find(id);
            if (thongtinSuCo == null)
            {
                return HttpNotFound();
            }
            return View(thongtinSuCo);
        }

        // POST: ThongtinSuCoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThongtinSuCo thongtinSuCo = db.ThongtinSuCos.Find(id);
            db.ThongtinSuCos.Remove(thongtinSuCo);
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
