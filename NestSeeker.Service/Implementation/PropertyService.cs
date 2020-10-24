using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NestSeeker.Persistence.Infrastructure;
using NestSeeker.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Implementation
{
    public class PropertyService : IPropertyService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PropertyService(IUnitOfWork unitOfWork) // Constructor Injection
        {
            this._unitOfWork = unitOfWork;
        }
       
        public IEnumerable<Property> GetAllUser()
        {
            return (IEnumerable<Property>)this._unitOfWork.PropertyRepository.GetAll();
        }

       
        public Property AddProperty(Property property)
        {
            /* NestSeekerContext context = new NestSeekerContext();
             context.Users.Add(user);
             context.SaveChanges();
             return user.Id;*/


            this._unitOfWork.PropertyRepository.Add(property);
            this._unitOfWork.Save();
            return property;
        }

        public Property GetById(int id)
        {
            throw new NotImplementedException();
            //return _unitOfWork.PropertyRepository.GetById(id);
        }
        /* public bool DeleteProperty(int propertyId)
{
    Property property = this._unitOfWork.PropertyRepository.GetById(propertyId);
    if (property != null)
    {
        this._unitOfWork.UserRepository.Remove(property);
        this._unitOfWork.Save();
        return true;
    }
    return false;
}

/* public Property UpdateProperty(Property property)
{
    this._unitOfWork.UserRepository.Update(property);
    this._unitOfWork.Save();
    return property;

}*/


    }
}
