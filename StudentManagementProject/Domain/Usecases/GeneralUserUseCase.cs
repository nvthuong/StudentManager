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
    public abstract class GeneralUserUseCase
    {
        private UserUseCase presenterCallback;
        protected UserRepository userRepo;

        public GeneralUserUseCase(UserUseCase userUseCase)
        {
            this.presenterCallback = userUseCase;
        }

        public void process(User user)
        {
            User resultUser = userRepo.process(user);
            navigateResultProcess(resultUser);
        }

        protected void navigateResultProcess(User user)
        {
            if (user == null)
            {
                this.presenterCallback.notifyUiGiveError();
            }
            else
            {
                this.presenterCallback.notifyUiToLogin(user);
            }
        }
        
    }
}
