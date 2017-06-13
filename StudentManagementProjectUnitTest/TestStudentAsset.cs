using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Data.Clients.Database;
using System.IO;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using Windows.Storage;

namespace StudentManagementProjectUnitTest
{
    [TestClass]
    public class TestStudentAsset
    {
        private const String ASSET_DATABASE_FILE = @"assets\database.xml";

        [TestMethod]
        public void addAllStudent()
        {
            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            // Delete all to make a new test
            studentDAO.deleteAllStudent();
            StorageFolder currentFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile databaseFile = currentFolder.GetFileAsync(ASSET_DATABASE_FILE).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            Stream databaseStream = databaseFile.OpenStreamForReadAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            XDocument xDocument = XDocument.Load(databaseStream);
            XElement rootElement = xDocument.Root;

            var classItem = rootElement.Elements("Class");
            List<Student> studentList = new List<Student>();
            foreach (var item in classItem)
            {
                String className = item.Attribute("name").Value;

                var students = item.Elements();
                foreach (var student in students)
                {
                    Student newStudent = new Student()
                    {
                        Name = student.Attribute("name").Value,
                        ClassName = className,
                        Gender = student.Attribute("gender").Value == "Male" ? true : false,
                        ImagePath = student.Attribute("img").Value,
                    };
                    studentList.Add(newStudent);
                    // studentDAO.addStudent(newStudent);
                }
            }
            Assert.IsTrue(studentDAO.addAllStudent(studentList));
        }

        [TestMethod]
        public void addStudent()
        {
            Student newStudent = new Student()
            {
                Name = "Huy",
                ClassName = "1A",
                Gender = true,
                ImagePath = ""
            };
            Assert.IsTrue(StudentDatabaseCall.getInstance().addStudent(newStudent));
        }

        [TestMethod]
        public void modifyStudent()
        {
            addNewStudentList();
            // Modify first student info with name "Paul Kardishan" <- only one
            String name = "Paul Kardishan";

            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            
            List<Student> lstOfStudent = studentDAO.getStudentListByName(name);
            Student firstStudent = lstOfStudent[0];
            firstStudent.Gender = false;
            
            // Update and check
            Assert.IsTrue(studentDAO.modifyStudent(firstStudent));

            // Check if result is changed
            List<Student> lstOfStudentAfterModified = studentDAO.getStudentListByName(name);
            Assert.AreEqual(lstOfStudentAfterModified[0].Gender, firstStudent.Gender);
        }

        [TestMethod]
        public void deleteStudent()
        {
            addNewStudentList();
            // Modify first student info with name "Paul Kardishan" <- only one
            String name = "Paul Kardishan";

            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();

            List<Student> lstOfStudent = studentDAO.getStudentListByName(name);
            Student firstStudent = lstOfStudent[0];

            // Update and check
            Assert.IsTrue(studentDAO.deleteStudent(firstStudent));

            // Check if result is changed
            List<Student> lstOfStudentAfterModified = studentDAO.getStudentListByName(name);
            Assert.AreEqual(lstOfStudentAfterModified.Count, 0);
        }

        [TestMethod]
        public void listStudent()
        {
            addNewStudentList();
            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            List<Student> lstOfStudent = studentDAO.getStudentList();
            Assert.IsNotNull(lstOfStudent);
            Assert.AreNotEqual(lstOfStudent.Count, 0);
        }

        [TestMethod]
        public void listStudentByName()
        {
            addNewStudentList();
            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            List<Student> lstOfStudent = studentDAO.getStudentListByName("Job");
            Assert.IsNotNull(lstOfStudent);
            Assert.AreNotEqual(lstOfStudent.Count, 0);
        }

        [TestMethod]
        public void listStudentByClassName()
        {
            addNewStudentList();
            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            List<Student> lstOfStudent = studentDAO.getStudentListByClassName("1A");
            Assert.IsNotNull(lstOfStudent);
            Assert.AreNotEqual(lstOfStudent.Count, 0);
        }

        private void addNewStudentList()
        {
            StudentDatabaseCall studentDAO = StudentDatabaseCall.getInstance();
            // Delete all to make a new test
            studentDAO.deleteAllStudent();
            StorageFolder currentFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            StorageFile databaseFile = currentFolder.GetFileAsync(ASSET_DATABASE_FILE).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
            Stream databaseStream = databaseFile.OpenStreamForReadAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            XDocument xDocument = XDocument.Load(databaseStream);
            XElement rootElement = xDocument.Root;

            var classItem = rootElement.Elements("Class");
            List<Student> studentList = new List<Student>();
            foreach (var item in classItem)
            {
                String className = item.Attribute("name").Value;

                var students = item.Elements();
                foreach (var student in students)
                {
                    Student newStudent = new Student()
                    {
                        Name = student.Attribute("name").Value,
                        ClassName = className,
                        Gender = student.Attribute("gender").Value == "Male" ? true : false,
                        ImagePath = student.Attribute("img").Value,
                    };
                    studentList.Add(newStudent);
                    // studentDAO.addStudent(newStudent);
                }
            }
            studentDAO.addAllStudent(studentList);
        }
    }
}
