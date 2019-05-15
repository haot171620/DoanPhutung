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
    public class TaiKhoanController : Controller
    {
        private CsK23T2bEntities db = new CsK23T2bEntities();

        // GET: /TaiKhoan/
        public ActionResult Index()
        {
            return View(db.Lienhes.ToList());
        }

        // GET: /TaiKhoan/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe nguoidung = db.Lienhes.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }

        // GET: /TaiKhoan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TaiKhoan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,Ho,Ten,Tuoi,Ngaysinh,SDT,Diachi,Gioitinh")] Lienhe nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Lienhes.Add(nguoidung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nguoidung);
        }

        // GET: /TaiKhoan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe nguoidung = db.Lienhes.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }

        // POST: /TaiKhoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Ho,Ten,Tuoi,Ngaysinh,SDT,Diachi,Gioitinh")] Lienhe nguoidung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoidung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nguoidung);
        }

        // GET: /TaiKhoan/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lienhe nguoidung = db.Lienhes.Find(id);
            if (nguoidung == null)
            {
                return HttpNotFound();
            }
            return View(nguoidung);
        }

        // POST: /TaiKhoan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lienhe nguoidung = db.Lienhes.Find(id);
            db.Lienhes.Remove(nguoidung);
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
