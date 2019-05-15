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
    public class tableOrdersController : Controller
    {
        private CsK23T2bEntities db = new CsK23T2bEntities();

        // GET: tableOrders
        public ActionResult Index()
        {
            return View(db.tableOrders.ToList());
        }

        // GET: tableOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableOrder tableOrder = db.tableOrders.Find(id);
            if (tableOrder == null)
            {
                return HttpNotFound();
            }
            return View(tableOrder);
        }

        // GET: tableOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tableOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idSP,tenSP,hinhSP,dongiaSP,soluongSP,thanhtien,ghichu")] tableOrder tableOrder)
        {
            if (ModelState.IsValid)
            {
                db.tableOrders.Add(tableOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableOrder);
        }

        // GET: tableOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableOrder tableOrder = db.tableOrders.Find(id);
            if (tableOrder == null)
            {
                return HttpNotFound();
            }
            return View(tableOrder);
        }

        // POST: tableOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idSP,tenSP,hinhSP,dongiaSP,soluongSP,thanhtien,ghichu")] tableOrder tableOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableOrder);
        }

        // GET: tableOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tableOrder tableOrder = db.tableOrders.Find(id);
            if (tableOrder == null)
            {
                return HttpNotFound();
            }
            return View(tableOrder);
        }

        // POST: tableOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tableOrder tableOrder = db.tableOrders.Find(id);
            db.tableOrders.Remove(tableOrder);
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
