﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Data.Model
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Property> Property { get; set; }
    }
}
