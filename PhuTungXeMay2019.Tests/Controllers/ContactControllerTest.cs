using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhuTungXeMay2019.Models;
using PhuTungXeMay2019.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace PhuTungXeMay2019.Tests
{
    [TestClass]
    public class ContactControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var db = new CsK23T2bEntities();
            var controller = new ContactController();

            var result = controller.Index();
            var view = result as ViewResult;
            Assert.IsNotNull(view);
            var model = view.Model as List<CONTACT>;
            Assert.IsNotNull(model);
            Assert.AreEqual(db.CONTACTs.Count(), model.Count);
        }
        [TestMethod]
        public void TestCreateG()
        {
            var controller = new ContactController();
            var result = controller.Create();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
        [TestMethod]
        public void TestEditG()
        {
            var db = new CsK23T2bEntities();
            var item = db.CONTACTs.First();
            var controller = new ContactController();

            var result = controller.Edit(0);
            Assert.IsInstanceOfType(result, typeof(HttpNotFoundResult));

            result = controller.Edit(item.idContact);
            var view = result as ViewResult;
            Assert.IsNotNull(view);
            var model = view.Model as CONTACT;
            Assert.IsNotNull(model);
            Assert.AreEqual(item.idContact, model.idContact);
            Assert.AreEqual(item.tenContact, model.tenContact);
            Assert.AreEqual(item.tenNguoidung, model.tenNguoidung);
            Assert.AreEqual(item.noidungContact, model.noidungContact);
            Assert.AreEqual(item.sdt, model.sdt);


        }
    }
}
