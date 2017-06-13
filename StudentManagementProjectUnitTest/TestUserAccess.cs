using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Data.Clients.Database;
using StudentManagementProject.Presentation.Systems;

namespace StudentManagementProjectUnitTest
{
    [TestClass]
    public class TestUserAccess
    {
        [TestMethod]
        public void addUser()
        {
            // Check added method
            Assert.IsTrue(addNewUser());
        }

        [TestMethod]
        public void checkUser()
        {
            // Ensure data before test
            addNewUser();

            User checkedUser = new User();
            checkedUser.Email = "nguyenhuy3588@gmail.com.vn";
            checkedUser.Password = "nguyenhuy3588";

            // Check email first
            Assert.IsTrue(CheckInputUtils.checkEmail(checkedUser.Email));
            Assert.IsTrue(CheckInputUtils.checkPassword(checkedUser.Password));

            // Check added method
            Assert.IsTrue(LoginRegisterDatabaseCall.getInstance().checkUser(checkedUser));
        }

        private Boolean addNewUser()
        {
            User newUser = new User();
            newUser.Email = "nguyenhuy3588@gmail.com.vn";
            newUser.Password = "nguyenhuy3588";
            newUser.Fullname = "Nguyen Anh Huy";
            newUser.Gender = true;
            newUser.ImgPath = "";

            // Check email first
            Assert.IsTrue(CheckInputUtils.checkEmail(newUser.Email));
            Assert.IsTrue(CheckInputUtils.checkPassword(newUser.Password));

            // Check added method
            return LoginRegisterDatabaseCall.getInstance().addUser(newUser);
        }
    }
}
