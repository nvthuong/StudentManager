using StudentManagementProject.Domain.Callbacks;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Presenters
{
    public class StudentPresenter : CreateStudentUseCaseCallback
    {
       private CreateStudentViewSurface viewSurface;
       private CreateStudentUseCase usecase;

       public StudentPresenter(CreateStudentViewSurface viewSurface)
       {
           this.viewSurface = viewSurface;
           usecase = new CreateStudentUseCase(this);
       }

       public void createStudent(Student student)
       {
           usecase.createStudent(student);
       }

       public interface CreateStudentViewSurface
       {
           void notifySuccess();
           void notifyFail();
       }

       public void notifySuccess()
       {
           viewSurface.notifySuccess();
       }

       public void notifyFail()
       {
           viewSurface.notifyFail();
       }
    }
}
