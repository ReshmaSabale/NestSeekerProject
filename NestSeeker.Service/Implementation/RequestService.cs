using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class RequestService : IRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RequestService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
        public Requests AddRequest(Requests requests)
        {
            this._unitOfWork.RequestsRepository.Add(requests);
            this._unitOfWork.Save();
            return requests;
        }

        public IEnumerable<Requests> GetAllRequests()
        {
            return this._unitOfWork.RequestsRepository.GetAll();
        }

        public Requests GetById(int id)
        {
            return this._unitOfWork.RequestsRepository.GetById(id);
        }
    }
}
