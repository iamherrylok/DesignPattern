﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlServerUser();
        }

        
    }
}
