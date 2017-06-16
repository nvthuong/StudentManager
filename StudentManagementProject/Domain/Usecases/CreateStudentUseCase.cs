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
    public class CreateStudentUseCase
    {
        private CreateStudentUseCaseCallback presentCallback;
        private CreateStudentRepository createStudentRepo;

        public CreateStudentUseCase(CreateStudentUseCaseCallback presentCallback)
        {
            this.presentCallback = presentCallback;
            createStudentRepo = new CreateStudentRepositoryImp();
        }

        public void createStudent(Student student)
        {
            bool result = createStudentRepo.createStudent(student);
            if (result)
            {
                presentCallback.notifySuccess();
            }
            else
            {
                presentCallback.notifyFail();
            }
        }
    }
}
