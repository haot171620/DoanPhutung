using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhuTungXeMay2019.Models;

namespace PhuTungXeMay2019.Controllers
{
    public class DonHangController : Controller
    {
        CsK23T2bEntities db = new CsK23T2bEntities();

        // GET: /DonHang/
        public ActionResult Index()
        {
            var model = db.DonHangs;
            return View(model.ToList());
        }

        // GET: /DonHang/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang model = db.DonHangs.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: /DonHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /DonHang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DonHang model)
        {
            if (ModelState.IsValid)
            {
                db.DonHangs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: /DonHang/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonHang model = db.DonHangs.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: /DonHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DonHang model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: /DonHang/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.DonHangs.Find(id);
            if (model == null)
                return HttpNotFound();
            db.DonHangs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // POST: /DonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DonHang donhang = db.DonHangs.Find(id);
            db.DonHangs.Remove(donhang);
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
