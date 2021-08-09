using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();

            IFactory factory = new SqlServerFactory();

            IUser userFromFactoty =  factory.CreateUser();
            IDepartment departmentFromFactory = factory.CreateDepartment();

            //给表添加记录
            userFromFactoty.Insert(user);
            //根据id获取表记录
            userFromFactoty.GetUser(1);

            //给表添加记录
            departmentFromFactory.Insert(department);
            //根据id获取表记录
            departmentFromFactory.GetDepartment(1);

        }
    }
}
