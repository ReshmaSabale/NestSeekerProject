using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserRoleService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<UserRole> GetAllUserRole()
        {
            return this._unitOfWork.UserRoleRepository.GetAll();
        }

        public UserRole GetById(int id)
        {
            return this._unitOfWork.UserRoleRepository.GetById(id);
        }
    }
}
