using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    class StatusService : IStatusService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StatusService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }

        public Status AddStatus(Status status)
        {
            this._unitOfWork.StatusRepository.Add(status);
            this._unitOfWork.Save();
            return status;
        }

        public IEnumerable<Status> GetAllStatus()
        {
            //throw new NotImplementedException();
            return this._unitOfWork.StatusRepository.GetAll();
        }

        
        public Status GetById(int id)
        {
            // throw new NotImplementedException();
            return this._unitOfWork.StatusRepository.GetById(id);
        }

       
    }
}
