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
    public class AuthorTest
    {
        AuthorContext ctx = DBContextManager.GetAuthorContext();
        Author AUTHOR;

        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("myid");
                //delete the test user if tests have been ran before
            }
            catch (Exception ex) { }
            Author item = new Author("myid", "Hristo", "Botev", "06.01.1848", "01.06.1876", "Poeziq");
            ctx.Create(item);
            AUTHOR = item;
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("myid");
            ctx.Create(AUTHOR);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("myid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Hristo", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            Author newauthor = new Author("myid", "Ivan", "Vazov", "09.07.1850", "22.09.1921", "Obshto vzeto pochti vseki janr");
            ctx.Update(newauthor);
            Assert.AreEqual("Ivan", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("myid");
            Assert.IsNull(ctx.Read("myid"));
            ctx.Create(AUTHOR);
        }
    }
}
