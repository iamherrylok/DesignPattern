using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL中根据id获取Department表格的一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SQL中给Department添加一条记录");
        }
    }
}
