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
    public class UserTest
    {
        UserContext ctx = DBContextManager.GetUserContext();
        User USER;

        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("myid");
                //delete the test user if tests have been ran before
            }
            catch (Exception ex) { }
            User item = new User("myid", "Spas", "Tzilkov", "12.12.2022");
            ctx.Create(item);
            USER = item;
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("myid");
            ctx.Create(USER);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("myid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Spas", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            User newuser = new User("myid", "Svetoslav", "Bonchev", "12.01.2023");
            ctx.Update(newuser);
            Assert.AreEqual("Svetoslav", ctx.Read("myid").Name);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("myid");
            Assert.IsNull(ctx.Read("myid"));
            ctx.Create(USER);
        }
    }
}
