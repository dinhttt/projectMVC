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
    public class NhatkyvanhanhsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: Nhatkyvanhanhs
        public ActionResult Index()
        {
            return View(db.Nhatkyvanhanhs.ToList());
        }

        // GET: Nhatkyvanhanhs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhatkyvanhanh nhatkyvanhanh = db.Nhatkyvanhanhs.Find(id);
            if (nhatkyvanhanh == null)
            {
                return HttpNotFound();
            }
            return View(nhatkyvanhanh);
        }

        // GET: Nhatkyvanhanhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nhatkyvanhanhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhatkyvanhanhID,MotaNhatky,Thongtinsuco,Luuluongvao,Luuluongra,Chisotieuthudien,Khoiluongtieuthudien,polymervao,polymerra,phabotvao,phabotra,NguoiTruc")] Nhatkyvanhanh nhatkyvanhanh)
        {
            if (ModelState.IsValid)
            {
                db.Nhatkyvanhanhs.Add(nhatkyvanhanh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhatkyvanhanh);
        }

        // GET: Nhatkyvanhanhs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhatkyvanhanh nhatkyvanhanh = db.Nhatkyvanhanhs.Find(id);
            if (nhatkyvanhanh == null)
            {
                return HttpNotFound();
            }
            return View(nhatkyvanhanh);
        }

        // POST: Nhatkyvanhanhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhatkyvanhanhID,MotaNhatky,Thongtinsuco,Luuluongvao,Luuluongra,Chisotieuthudien,Khoiluongtieuthudien,polymervao,polymerra,phabotvao,phabotra,NguoiTruc")] Nhatkyvanhanh nhatkyvanhanh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhatkyvanhanh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhatkyvanhanh);
        }

        // GET: Nhatkyvanhanhs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nhatkyvanhanh nhatkyvanhanh = db.Nhatkyvanhanhs.Find(id);
            if (nhatkyvanhanh == null)
            {
                return HttpNotFound();
            }
            return View(nhatkyvanhanh);
        }

        // POST: Nhatkyvanhanhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Nhatkyvanhanh nhatkyvanhanh = db.Nhatkyvanhanhs.Find(id);
            db.Nhatkyvanhanhs.Remove(nhatkyvanhanh);
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
