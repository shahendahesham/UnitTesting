using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Service;
using System;
using System.Linq;

namespace TestRepo
{
    [TestClass]
    public class UnitTest1
    {
        APIContext DB;
        UserRepo u;
         RoleRepo r;

        public UnitTest1()
        {
            DB = new APIContext();
            u = new UserRepo(DB);
            r = new RoleRepo(DB);

        }
        [TestMethod]
        public void AdminExist()
        {
            string name = "";
            var rdata = r.GetAll();
            var udata = u.GetAll();
            var usradmin = 0;
            var roleadmin = 0;
            foreach (var item in rdata)
            {
                if (item.Role_Name == "Admin")
                {
                    usradmin = 1;
                    name = "Admin";
                }
            }
            
            Assert.IsTrue(name == "Admin");
        }
        [TestMethod]
        public void LoginTest()
        {
            bool res = u.Login("fatmamedhat25@gmail.com", "1234");
            Assert.IsTrue(res);
        }
    }
}
//foreach (var item in udata)
//{
//    if (item.Name == "Admin")
//    {
//        roleadmin = 1;

//    }
//}
//if (roleadmin == 1 && usradmin == 1)
//{
//    name = "Admin";
//}