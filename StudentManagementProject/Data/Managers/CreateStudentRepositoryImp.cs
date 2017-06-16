using StudentManagementProject.Data.Clients.Database;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Data.Managers
{
    class CreateStudentRepositoryImp : CreateStudentRepository
    {
        public bool createStudent(Student student)
        {
            return StudentDatabaseCall.getInstance().addStudent(student);
        }
    }
}
