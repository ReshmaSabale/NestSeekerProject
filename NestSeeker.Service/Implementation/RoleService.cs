using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoleService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
        public Role AddRole(Role role)
        {
            this._unitOfWork.RoleRepository.Add(role);
            this._unitOfWork.Save();
            return role;
        
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return this._unitOfWork.RoleRepository.GetAll();
        }

        public Role GetById(int id)
        {
            return this._unitOfWork.RoleRepository.GetById(id);
        }
    }
}
