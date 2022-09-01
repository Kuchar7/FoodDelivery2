﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain.Common
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastDateModified { get; set; }
    }
}