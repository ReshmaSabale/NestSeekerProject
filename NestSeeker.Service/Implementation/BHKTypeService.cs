using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class BHKTypeService : IBHKTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BHKTypeService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
        public BHKType AddBHKType(BHKType bhkType)
        {
            // throw new NotImplementedException();
            this._unitOfWork.BHKTypeRepository.Add(bhkType);
            this._unitOfWork.Save();
            return bhkType;
        }

        public IEnumerable<BHKType> GetAllBHKTypes()
        {
            return this._unitOfWork.BHKTypeRepository.GetAll();
        }

        public BHKType GetById(int id)
        {
            return this._unitOfWork.BHKTypeRepository.GetById(id);
        }
    }
}
