using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Data.Clients.Database;

namespace StudentManagementProjectUnitTest
{
    [TestClass]
    public class TestClassAccess
    {
        [TestMethod]
        public void addClassList()
        {
            String[] className = {"1A", "1B", "1C", "1D", "1E",
                                 "2A", "2B", "2C", "2D", "2E",
                                 "3A", "3B", "3C", "3D", "3E",
                                 "4A", "4B", "4C", "4D", "4E",
                                 "5A", "5B", "5C", "5D", "5E"};

            // Delete all to make a new test
            ClassDatabaseCall.getInstance().deleteAllClass();

            foreach (String curClass in className)
            {
                Class addedClass = new Class();
                addedClass.Name = curClass;
                ClassDatabaseCall classDAO = ClassDatabaseCall.getInstance();
                Assert.IsTrue(classDAO.addClass(addedClass));
            }
        }

        [TestMethod]
        public void getClassList()
        {
            // Ensure we have data to test
            addClassList();

            ClassDatabaseCall classDAO = ClassDatabaseCall.getInstance();

            List<Class> returnClass = classDAO.getClassList();
            
            Assert.IsNotNull(returnClass);
            Assert.AreNotEqual(returnClass.Count, 0);
        }

    }
}
