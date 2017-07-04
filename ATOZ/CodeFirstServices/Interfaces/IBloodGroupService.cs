﻿using CodeFirstEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstServices.Interfaces
{
 public   interface IBloodGroupService
    {
        IEnumerable<BloodGroup> GetBloodGroup();
        string GetTypeOfSupplier(int id);
        BloodGroup GetBloodGroupById(int id);
    }
}
