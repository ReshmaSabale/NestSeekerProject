﻿using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
   public interface IPropertyTypeService
    {
        IEnumerable<PropertyType> GetAllPropertyType();
        PropertyType GetById(int id);
        PropertyType AddProperty(PropertyType propertytype);
        
    }
}
