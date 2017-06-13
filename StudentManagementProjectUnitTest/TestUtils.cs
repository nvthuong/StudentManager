using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StudentManagementProject.Presentation.Systems;

namespace StudentManagementProjectUnitTest
{
    [TestClass]
    public class TestUtils
    {
        [TestMethod]
        public void checkEmailValid()
        {
            String email = "nguyenhuy3588@gmail.com.vn";
            String email2 = "nguyenhuy3588@yahoo.com.vn";
            String email3 = "nguyenhuy3588@tma.com.vn";

            Assert.IsTrue(CheckInputUtils.checkEmail(email));
            Assert.IsTrue(CheckInputUtils.checkEmail(email2));
            Assert.IsTrue(CheckInputUtils.checkEmail(email3));
        }

        [TestMethod]
        public void checkEmailInvalidWithWrongHostName()
        {
            String email = "nguyenhuy3588@bing.com.vn";

            Assert.IsFalse(CheckInputUtils.checkEmail(email));
        }

        [TestMethod]
        public void checkEmailInvalidWithWrongDomainName()
        {
            String email = "nguyenhuy3588@yahoo.com";

            Assert.IsFalse(CheckInputUtils.checkEmail(email));
        }

        [TestMethod]
        public void checkPasswordLengthValid()
        {
            String pass = "hahaha123456";

            Assert.IsTrue(CheckInputUtils.checkPassword(pass));
        }

        [TestMethod]
        public void checkPasswordInvalidWithWrongLength()
        {
            String pass = "haa126";

            Assert.IsFalse(CheckInputUtils.checkPassword(pass));
        }

        [TestMethod]
        public void checkPasswordCharacterValid()
        {
            String pass = "hahaha123456";

            Assert.IsTrue(CheckInputUtils.checkPassword(pass));
        }

        [TestMethod]
        public void checkPasswordInvalidWhenMissingDigit()
        {
            String pass = "haaasfasfasfas";

            Assert.IsFalse(CheckInputUtils.checkPassword(pass));
        }

        [TestMethod]
        public void checkPasswordInvalidWhenMissingCharacter()
        {
            String pass = "2421421421421421";

            Assert.IsFalse(CheckInputUtils.checkPassword(pass));
        }

        //[TestMethod]
        //public void checkImagePathExist()
        //{
        //    String path = @"\Assets\ApplicationIcon.png";

        //    Assert.IsTrue(CheckImgPathUtils.checkImagePathExisted(path));
        //}

        //[TestMethod]
        //public void checkImagePathNotExist()
        //{
        //    String path = @"\Assets\ApplicationIcon2.png";

        //    Assert.IsFalse(CheckImgPathUtils.checkImagePathExisted(path));
        //}

        //[TestMethod]
        //public void checkImagePathSupportedExtention()
        //{
        //    String path = @"\Assets\ApplicationIcon.png";

        //    Assert.IsFalse(CheckImgPathUtils.checkImagePathSupportedExtension(path));
        //}

        //[TestMethod]
        //public void checkImagePathNotSupportedExtention()
        //{
        //    String path = @"\Assets\ApplicationIcon.gif";

        //    Assert.IsTrue(CheckImgPathUtils.checkImagePathSupportedExtension(path));
        //}
    }
}
