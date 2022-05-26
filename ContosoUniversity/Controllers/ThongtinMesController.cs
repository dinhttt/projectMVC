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
using PagedList;

namespace ContosoUniversity.Controllers
{
    public class ThongtinMesController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: ThongtinMes
        //public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        public ViewResult Index(int? page)
        {
            return View(db.ThongtinMes.ToList());
        }

        // GET: ThongtinMes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinMe thongtinMe = db.ThongtinMes.Find(id);
            if (thongtinMe == null)
            {
                return HttpNotFound();
            }
            return View(thongtinMe);
        }

        // GET: ThongtinMes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongtinMes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ThongTinMeID,ThongTinMeCode,Begom,CycloTron,Belang,BomHoaChat,BeDieuHoa,BeSBR1,BeSBR2,MayEpBun")] ThongtinMe thongtinMe)
        {
            thongtinMe.CreateBy = "MayDinhTest";
            thongtinMe.CreateDate = DateTime.Now;
            thongtinMe.UpdateBy = "MayDinhTest";
            thongtinMe.UpdateDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.ThongtinMes.Add(thongtinMe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thongtinMe);
        }

        // GET: ThongtinMes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinMe thongtinMe = db.ThongtinMes.Find(id);
            if (thongtinMe == null)
            {
                return HttpNotFound();
            }
            return View(thongtinMe);
        }

        // POST: ThongtinMes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ThongTinMeID,ThongTinMeCode,CreateBy,CreateDate,UpdateBy,UpdateDate,Begom,CycloTron,Belang,BomHoaChat,BeDieuHoa,BeSBR1,BeSBR2,MayEpBun")] ThongtinMe thongtinMe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thongtinMe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thongtinMe);
        }

        // GET: ThongtinMes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThongtinMe thongtinMe = db.ThongtinMes.Find(id);
            if (thongtinMe == null)
            {
                return HttpNotFound();
            }
            return View(thongtinMe);
        }

        // POST: ThongtinMes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThongtinMe thongtinMe = db.ThongtinMes.Find(id);
            db.ThongtinMes.Remove(thongtinMe);
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
