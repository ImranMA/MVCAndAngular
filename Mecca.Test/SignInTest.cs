using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mecca.Models;
using Mecca.Controllers;
using Mecca.IOCContainer;

namespace Mecca.Test
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void CheckSignIn()
        {
            MeccaUnityManager.Register();

            UserModel um = new UserModel();
            um.UserName = "admin";
            um.Password = "admin";       
       
            Assert.AreEqual(true,  um.AuthenticateUser(um));
        }
    }
}
