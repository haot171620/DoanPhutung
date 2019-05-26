﻿using System;
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
    public class ContactController : Controller
    {
        private CsK23T2bEntities db = new CsK23T2bEntities();

        // GET: /Contact/
        public ActionResult Index(string searchString)
        {

            var links = from l in db.CONTACTs 
                        select l;
            if (!String.IsNullOrEmpty(searchString)) 
            {
                links = links.Where(s => s.tenNguoidung.Contains(searchString)); 
            }
            return View(db.CONTACTs.ToList());
        }

        // GET: /Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTACT contact = db.CONTACTs.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: /Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="idContact,tenContact,noidungContact,idNguoidung,tenNguoidung,hinhanhNguoidung,gioitinh,diachi,sdt,ghichu")] CONTACT contact)
        {
            if (ModelState.IsValid)
            {
                db.CONTACTs.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: /Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTACT contact = db.CONTACTs.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: /Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="idContact,tenContact,noidungContact,idNguoidung,tenNguoidung,hinhanhNguoidung,gioitinh,diachi,sdt,ghichu")] CONTACT contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: /Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONTACT contact = db.CONTACTs.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: /Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CONTACT contact = db.CONTACTs.Find(id);
            db.CONTACTs.Remove(contact);
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
