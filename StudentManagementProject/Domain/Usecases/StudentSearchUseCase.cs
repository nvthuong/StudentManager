using StudentManagementProject.Data.Managers;
using StudentManagementProject.Domain.Callbacks;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Domain.Usecases
{
    public class StudentSearchUseCase
    {
        private StudentUseCaseCallback studentUseCaseCallback;
        private StudentRepository studentRPos;

        private List<StudentRepository> studentRpSamples;

        public StudentSearchUseCase(StudentUseCaseCallback callback)
        {
            studentUseCaseCallback = callback;
            studentRpSamples = new List<StudentRepository>();
            studentRpSamples.Add(new StudentSearchByNameRepoImp());
            studentRpSamples.Add(new StudentSearchByClassRepoImp());

        }

        public async void searchAll()
        {
            studentRPos = studentRpSamples[0];
            List<Student> studentList = await studentRPos.performSearch();
            if (studentList.Count > 0)
            {
                studentUseCaseCallback.notifyUpdateStudentList(studentList);
            }
            else
            {
                studentUseCaseCallback.notifyUpdateFail();
            }
        }

        public async void searchByName(String name)
        {
            studentRPos = studentRpSamples[0];
            List<Student> studentList = await studentRPos.performSearch(name);
            if (studentList.Count > 0)
            {
                studentUseCaseCallback.notifyUpdateStudentList(studentList);
            }
            else
            {
                studentUseCaseCallback.notifyUpdateFail();
            }
        }

        public async void searchByClassName(String name)
        {
            studentRPos = studentRpSamples[1];
            List<Student> studentList = await studentRPos.performSearch(name);
            if (studentList.Count > 0)
            {
                studentUseCaseCallback.notifyUpdateStudentList(studentList);
            }
            else
            {
                studentUseCaseCallback.notifyUpdateFail();
            }
        }
    }
}
