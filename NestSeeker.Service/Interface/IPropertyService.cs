using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IPropertyService
    {
        IEnumerable<Property> GetAllProperty();
        Property GetById(int id);
        Property AddProperty(Property property);
      //  Property UpdateProperty(Property property);
       // Property DeleteProperty(int propertyId);
    }
}
