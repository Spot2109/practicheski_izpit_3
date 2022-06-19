using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using ServiceLayer;

namespace TestLayer
{
    [TestClass]
    public class BookTest
    {
        BookContext ctx = DBContextManager.GetBookContext();
        Book BOOK;

        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("myid");
                //delete the test user if tests have been ran before
            }
            catch (Exception ex) { }
            Book item = new Book("myid", "Jelezniq svetilnik", "Roman");
            ctx.Create(item);
            BOOK = item;
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("myid");
            ctx.Create(BOOK);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("myid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Jelezniq svetilnik", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            Book newbook = new Book("myid", "Pod Igoto", "Roman");
            ctx.Update(newbook);
            Assert.AreEqual("Pod Igoto", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("myid");
            Assert.IsNull(ctx.Read("myid"));
            ctx.Create(BOOK);
        }
    }
}