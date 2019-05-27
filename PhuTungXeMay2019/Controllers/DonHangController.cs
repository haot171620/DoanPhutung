using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhuTungXeMay2019.Models;
using System.Transactions;

namespace PhuTungXeMay2019.Controllers
{
    public class DonHangController : Controller
    {
        CsK23T2bEntities db = new CsK23T2bEntities();

        // GET: /DonHang/
        public ActionResult Index()
        {
            var model = db.Donhangs;
            return View(model.ToList());
        }

        // GET: /DonHang/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang model = db.Donhangs.Find(id);
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
        public ActionResult Create(Donhang model)
        {
            ValidateDonhang(model);
            if (ModelState.IsValid)
            {
                using (var scope = new TransactionScope())
                {
                    // add model to database
                    db.Donhangs.Add(model);
                    db.SaveChanges();
                    // save file to App_Data
                    var path = Server.MapPath("~/App_Data");
                    path = System.IO.Path.Combine(path, model.IdDonhang.ToString());
                    Request.Files["Image"].SaveAs(path);
                    // accept all and persistence
                    scope.Complete();
                    return RedirectToAction("Index");
                }
            }

                return View(model);
            }
        

        // GET: /DonHang/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.Donhangs.Find(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }
        private void ValidateDonhang(Donhang model)
        {
            if (model.Gia <= 0)
                ModelState.AddModelError("Price", VLTError.PRICE_LESS_0);
        }


        // POST: /DonHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Donhang model)
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
            var model = db.Donhangs.Find(id);
            if (model == null)
                return HttpNotFound();
            db.Donhangs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // POST: /DonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Donhang donhang = db.Donhangs.Find(id);
            db.Donhangs.Remove(donhang);
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
