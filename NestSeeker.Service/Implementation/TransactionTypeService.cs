using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransactionTypeService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }

        public TransactionType AddTransactionType(TransactionType transactionType)
        {
            //throw new NotImplementedException();
            this._unitOfWork.TransactionTypeRepository.Add(transactionType);
            this._unitOfWork.Save();
            return transactionType;
        }

        public IEnumerable<TransactionType> GetAlltransactiontypes()
        {
            return this._unitOfWork.TransactionTypeRepository.GetAll();
        }

        public TransactionType GetById(int id)
        {
            return this._unitOfWork.TransactionTypeRepository.GetById(id);
        }
    }
}
