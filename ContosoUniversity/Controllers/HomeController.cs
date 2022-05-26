using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;


namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
            /*
            var nhatkyvanhanhs = new List<Nhatkyvanhanh>
            {
                new Nhatkyvanhanh{Luuluongra = 10, Chisotieuthudien = 10 },
                new Nhatkyvanhanh{Luuluongra = 20, Chisotieuthudien = 20 },
                new Nhatkyvanhanh{Thongtinsuco = "Nha May chay" , Chisotieuthudien = 20 },

            };
            for(int i = 0; i < nhatkyvanhanhs.Count(); i++)
            {
                db.Nhatkyvanhanhs.Add(nhatkyvanhanhs[i]);
            }
            db.SaveChanges();
            */


            return View();
        }

        public ActionResult About()
        {
            // Commenting out LINQ to show how to do the same thing in SQL.
            //IQueryable<EnrollmentDateGroup> = from student in db.Students
            //           group student by student.EnrollmentDate into dateGroup
            //           select new EnrollmentDateGroup()
            //           {
            //               EnrollmentDate = dateGroup.Key,
            //               StudentCount = dateGroup.Count()
            //           };

            // SQL version of the above LINQ code.
            string query = "SELECT EnrollmentDate, COUNT(*) AS StudentCount "
                + "FROM Person "
                + "WHERE Discriminator = 'Student' "
                + "GROUP BY EnrollmentDate";
            IEnumerable<EnrollmentDateGroup> data = db.Database.SqlQuery<EnrollmentDateGroup>(query);

            return View(data.ToList());
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}