using NestSeeker.Data.Model;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
   public  class PropertyTypeService:IPropertyTypeService
    {

        private readonly IUnitOfWork _unitOfWork;
        public PropertyTypeService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<PropertyType> GetAllPropertyType()
        {
            return this._unitOfWork.ProprtyTypeRepository.GetAll();
        }

        public PropertyType GetById(int id)
        {
            return this._unitOfWork.ProprtyTypeRepository.GetById(id);
        }
       
        public PropertyType AddProperty(PropertyType propertytype)
        {
            // throw new NotImplementedException();
            this._unitOfWork.ProprtyTypeRepository.Add(propertytype);
            this._unitOfWork.Save();
            return propertytype;
        }

        
    }
}
